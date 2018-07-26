using System;
namespace Clopay
{
    /// <summary>
    /// Model represents the MenuItem
    /// </summary>
    public class MenuItem
    {
        /// <summary>
        /// Gets or sets Icon Source
        /// </summary>
        public string IconSource
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets Target Type
        /// </summary>
        public Type TargetType
        {
            get;
            set;
        }
    }
}
