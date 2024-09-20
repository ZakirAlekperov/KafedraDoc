using System.Reflection.Metadata;

namespace KafedraDoc.Models
{
    /// <summary>
    /// Представляет учебный план.
    /// </summary>
    public class CurriculumProgram
    {
        /// <summary>
        /// Уникальный идентификатор учебного плана.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Название учебного плана.
        /// </summary>
        public string Name { get; set; }
        
        /// <summary>
        /// Специализация, к которой относится учебный план.
        /// </summary>
        public string Specialization { get; set; }

        /// <summary>
        /// Год набора по плану.
        /// </summary>
        public int Year { get; set; }
        
        /// <summary>
        /// Описание учебного плана.
        /// </summary>
        public string Description { get; set; }
    }
}
