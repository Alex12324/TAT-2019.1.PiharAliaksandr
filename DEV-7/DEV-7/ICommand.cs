﻿
namespace DEV_7
{
    /// <summary>
    /// Interface for pattern command.
    /// </summary>
    interface ICommand
    {
        /// <summary>
        /// Interface method.
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        int Execute(string type);
    }
}
