using Microsoft.AspNetCore.Identity;

namespace KafedraDoc.Models
{
    /// <summary>
    /// Представляет пользователя системы.
    /// </summary>
    public class User
    {
        /// <summary>
        /// Уникальный идентификатор пользователя.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Полное имя пользователя.
        /// </summary>
        public string FullName { get; set; }

        /// <summary>
        /// Электронная почта пользователя.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Пароль пользователя (рекомендуется хранить в зашифрованном виде).
        /// </summary>
        public string Password  { get; set; }

        /// <summary>
        /// Роль пользователя (например, секретарь, ассистент, преподаватель, зав. кафедрой).
        /// </summary>
        public Role Role { get; set; }
    }
}
