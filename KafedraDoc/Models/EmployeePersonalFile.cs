namespace KafedraDoc.Models
{
    /// <summary>
    /// Представляет личное дело сотрудника.
    /// </summary>
    public class EmployeePersonalFile
    {
        /// <summary>
        /// Уникальный идентификатор личного дела.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Полное имя сотрудника.
        /// </summary>
        public string FullName {  get; set; }

        /// <summary>
        /// Должность сотрудника.
        /// </summary>
        public string Position {  get; set; }

        /// <summary>
        /// Дата рождения сотрудника.
        /// </summary>
        public DateTime BirthDate { get; set; }

        /// <summary>
        /// Образование сотрудника.
        /// </summary>
        public string Education { get; set; }

        /// <summary>
        /// Номер телефона сотрудника.
        /// </summary>
        public string PhoneNumber { get; set; }
        
        /// <summary>
        /// Электронная почта сотрудника.
        /// </summary>
        public string Email { get; set; }
    }
}
