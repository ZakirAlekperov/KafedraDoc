namespace KafedraDoc.Models
{
    /// <summary>
    /// Представляет роль пользователя в системе.
    /// </summary>
    public class Role
    {
        /// <summary>
        /// Уникальный идентификатор роли.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Название роли(например, секретарь, ассистент, преподаватель, зав кафедрой).
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Описание прав доступа для данной роли.
        /// </summary>
        public string Description { get; set; }
    }
}
