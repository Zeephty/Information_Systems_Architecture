using BLogic.Interfaces;
using BLogic.Realization;
using DataAccessLayer;
using Model;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLogic
{
    /// <summary>
    /// Модуль конфигурации Ninject для настройки внедрения зависимостей (DI).
    /// Отвечает за связывание интерфейсов с конкретными реализациями 
    /// </summary>
    public class ConfigModule : NinjectModule
    {
        /// <summary>
        /// Тип источника данных, который будет использоваться по умолчанию.
        /// </summary>
        private readonly DataSourceKind defaultKind;

        /// <summary>
        /// Инициализирует новый экземпляр модуля конфигурации Ninject.
        /// </summary>
        /// <param name="defaultKind"> Источник данных, выбираемый по умолчанию </param>
        public ConfigModule(DataSourceKind defaultKind)
        {
            this.defaultKind = defaultKind;
        }

        /// <summary>
        /// Загружает правила привязки зависимостей. 
        /// Настраивает репозиторий и бизнес-логику как синглтоны (Singleton).
        /// </summary>
        public override void Load()
        {
            Bind<IRepository<Robot>>().ToMethod(context => RepositoryFactory.Create(this.defaultKind)).InSingletonScope();

            Bind<RepositoryProvider>().ToSelf().InSingletonScope();

            Bind<IOperationsCRUD>().To<OperationsCRUD>().InSingletonScope();
            Bind<IGroupByTypeFunction>().To<CGroupByTypeFunction>().InSingletonScope();
            Bind<IAveragePriceFunction>().To<CAveragePriceFunction>().InSingletonScope();

            Bind<ILogic>().To<Logic2>().InSingletonScope();
        }
    }
}
