namespace KafedraDoc.Models
{
    /// <summary>
    /// Представляет протокол заседания кафедры.
    /// </summary>
    public class DepartmentMeetingMinutes
    {
        /// <summary>
        /// Уникальный идентификатор протокола.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Дата заседания кафедры.
        /// </summary>
        public DateTime MeetingDate { get; set; }

        /// <summary>
        /// Повестка дня заседания.
        /// </summary>
        public string Agenda { get; set; }

        /// <summary>
        /// Принятые решения на заседании.
        /// </summary>
        public string Decisions {  get; set; }

        /// <summary>
        /// Участники заседания.
        /// </summary>
        public string Participants { get; set; }
    }
}
