﻿//                                  ┌∩┐(◣_◢)┌∩┐
//                                                                              \\
// WindowsController.cs (00/00/0000)                                             	\\
// Autor: Antonio Mateo (.\Moon Antonio)    antoniomt.moon@gmail.com            \\
//******************************************************************************\\

#region Librerias
using UnityEngine;
#endregion

namespace Moon
{
	/// <summary>
    /// <para></para>
    /// </summary>
	public class WindowsController : MonoBehaviour
	{
		#region Dev
        [ContextMenu("Dev")]
        protected void DevScript()
        {
            Debug.Log("<color=green>WindowsController :: DevScript()</color> >> Inicializado.");
        }
        #endregion
	}
}