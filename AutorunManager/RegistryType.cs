using Microsoft.Win32;

namespace AutorunManager
{
    /// <summary>
    /// Registry type class
    /// </summary>
    public class RegistryType
    {
        #region Attributes

        /// <summary>
        /// Name
        /// </summary>
        private string name;

        /// <summary>
        /// Value
        /// </summary>
        private object value;

        /// <summary>
        /// Kind
        /// </summary>
        private RegistryValueKind kind;

        #endregion

        #region Getter and setter

        /// <summary>
        /// Name
        /// </summary>
        public string Name
        {
            get
            {
                return name;
            }
        }

        /// <summary>
        /// Value
        /// </summary>
        public object Value
        {
            get
            {
                return value;
            }
        }

        /// <summary>
        /// Kind
        /// </summary>
        public RegistryValueKind Kind
        {
            get
            {
                return kind;
            }
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="name"></param>
        /// <param name="key"></param>
        public RegistryType(string name, RegistryKey key)
        {
            this.name = name;
            value = key.GetValue(name);
            kind = key.GetValueKind(name);
        }

        #endregion

        #region Methods

        /// <summary>
        /// To string
        /// </summary>
        /// <returns>Name</returns>
        public override string ToString()
        {
            return name;
        }

        #endregion
    }
}
