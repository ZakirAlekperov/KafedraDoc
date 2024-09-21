namespace KafedraDoc.Models
{
    /// <summary>
    /// Представляет соглашение или договор.
    /// </summary>
    public class Agreement
    {
        /// <summary>
        /// Уникальный идентификатор соглашения.
        /// </summary>
        public int Id { get; set; }
        
        /// <summary>
        /// Название соглашения или договора.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Стороны, участвующие в соглашении.
        /// </summary>
        public string Parties { get; set; }

        /// <summary>
        /// Дата подписания соглашения.
        /// </summary>
        public DateTime SigningDate { get; set; }

        /// <summary>
        /// Дата окончания действия соглашения.
        /// </summary>
        public DateTime ExpirationDate { get; set; }

        /// <summary>
        /// Описание соглашения или договора.
        /// </summary>
        public string Description { get; set; }
    }
}
