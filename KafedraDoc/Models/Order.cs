namespace KafedraDoc.Models
{
    /// <summary>
    /// Представляет приказ, изданный головным университетом или Министерством образования.
    /// </summary>
    public class Order
    {
        /// <summary>
        /// Уникальный идентификатор приказа.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Название приказа.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Орган, издавший приказ.
        /// </summary>
        public string IssuingAutority { get; set; }

        /// <summary>
        /// Описание содержания приказа.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Статус приказа (например, активен, отменён).
        /// </summary>
        public string Status { get; set; }
    }
}
