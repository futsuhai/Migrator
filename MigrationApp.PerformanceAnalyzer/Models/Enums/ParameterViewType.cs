namespace MigrationApp.PerformanceAnalyzer.Models.Enums;

   /// <summary>
    /// Тип отображения параметра.
    /// </summary>
    public enum ParameterViewType
    {
        /// <summary>
        /// Информационный.
        /// </summary>
        Info = 0,

        /// <summary>
        /// Набор чекбоксов.
        /// </summary>
        Multichoice = 1,

        /// <summary>
        /// Выпадающий список.
        /// </summary>
        DropDownList = 2,

        /// <summary>
        /// Нет на сайте (только в отчёт).
        /// </summary>
        OnlyReport = 3,

        /// <summary>
        /// Редактируемое поле.
        /// </summary>
        Input = 4,

        /// <summary>
        /// Параметр со значениями true либо false, представляется в виде checkbox.
        /// </summary>
        Bool = 5,

        /// <summary>
        /// Список из radio buttons.
        /// </summary>
        RadioButtonList = 6,

        /// <summary>
        /// Автозаполняемый параметр.
        /// </summary>
        Autofill = 7,

        /// <summary>
        /// Выпадающий список для выбора номера заявки.
        /// </summary>
        AppNumber = 8,

        /// <summary>
        /// Выпадающий список для выбора номера теста.
        /// </summary>
        TestNumber = 9,
    }