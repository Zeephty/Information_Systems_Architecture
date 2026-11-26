using BLogic.Interfaces;
using Model;
using Shared;
using System;
using System.Collections.Generic;
using System.Text;

namespace Presenter
{
    public class RobotPresenter
    {
        private readonly IView view;
        private readonly IObservableLogic logic;

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="view"> Представление </param>
        /// <param name="logic"> Логика </param>
        public RobotPresenter(IView view, IObservableLogic logic)
        {
            this.view = view;
            this.logic = logic;

            view.AddRobotRequested += OnAddRobot;
            view.UpdateRobotRequested += OnUpdateRobot;
            view.DeleteRobotRequested += OnDeleteRobot;
            view.FindRobotRequested += OnFindRobot;
            view.RefreshRequested += OnRefresh;
            view.ChangeSourceRequested += OnChangeSource;
            view.GroupByTypeRequested += OnGroupByType;
            view.AveragePriceRequested += OnAveragePrice;

            logic.DataChanged += OnRefresh;

            OnRefresh();
        }

        private void OnRefresh()
        {
            try
            {
                var robots = logic.GetAll().Select(MapToDto);
                view.ShowRobots(robots);
            } 
            catch (Exception ex)
            {
                view.ShowError(ex.Message);
            }
        }

        private void OnAddRobot(RobotDTO dto)
        {
            try
            {
                logic.Add(MapToDomain(dto));
                view.ShowMessage("Робот успешно добавлен.");
            }
            catch (Exception ex)
            { 
                view.ShowError(ex.Message); 
            }
        }

        private void OnUpdateRobot(RobotDTO dto)
        {
            try
            {
                logic.Update(MapToDomain(dto));
                view.ShowMessage("Данные обновлены.");
            }
            catch (Exception ex) 
            { 
                view.ShowError(ex.Message); 
            }
        }

        private void OnDeleteRobot(int id)
        {
            try
            {
                var robot = logic.GetById(id);
                if (robot != null)
                {
                    logic.Delete(robot);
                    view.ShowMessage("Робот удален.");
                }
            }
            catch (Exception ex) 
            { 
                view.ShowError(ex.Message); 
            }
        }

        private void OnFindRobot(int id)
        {
            try
            {
                var robot = logic.GetById(id);
                if (robot != null)
                {
                    view.ShowDetails(MapToDto(robot));
                }
                else 
                { 
                    view.ShowError("Робот не найден.");
                }
            }
            catch (Exception ex) 
            { 
                view.ShowError(ex.Message); 
            }
        }

        private void OnChangeSource(DataSourceKind kind)
        {
            try
            {
                var repo = DataAccessLayer.RepositoryFactory.Create(kind);
                logic.SetRepository(repo);
                view.UpdateSourceLabel(kind.ToString());
            }
            catch (Exception ex) 
            { 
                view.ShowError(ex.Message); 
            }
        }

        private void OnGroupByType()
        {
            try
            {
                var groups = logic.GroupByType().ToDictionary(g => g.Key, g => g.Value.Select(MapToDto).ToList());
                view.ShowGrouping(groups);
            }
            catch (Exception ex) 
            { 
                view.ShowError(ex.Message); 
            }
        }

        private void OnAveragePrice()
        {
            try 
            { 
                view.ShowAveragePrice(logic.AveragePriceBySeries()); 
            }
            catch (Exception ex) 
            { 
                view.ShowError(ex.Message); 
            }
        }

        private Robot MapToDomain(RobotDTO dto) => new Robot {
            Id = dto.Id,
            Number = dto.Number,
            Series = dto.Series,
            Type = dto.Type,
            Name = dto.Name,
            Goal = dto.Goal,
            Details = dto.Details,
            Appearance = dto.Appearance,
            CriteriaCodes = dto.CriteriaCodes,
            PriceRub = dto.PriceRub
        };

        private RobotDTO MapToDto(Robot robot) => new RobotDTO {
            Id = robot.Id,
            Number = robot.Number,
            Series = robot.Series,
            Type = robot.Type,
            Name = robot.Name,
            Goal = robot.Goal,
            Details = robot.Details,
            Appearance = robot.Appearance,
            CriteriaCodes = robot.CriteriaCodes,
            PriceRub = robot.PriceRub
        };
    }
}
