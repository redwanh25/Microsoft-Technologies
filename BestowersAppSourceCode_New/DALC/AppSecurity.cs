using System;
using System.Web;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Security.Principal;

namespace CIS.Lib.DALC
{
	//****************************************************************************
	//
	// AppUser Class
	// Author: Reza Nabi, reza@ksu.edu, CIS, KSU
	//
	// This class encapsulates 3 helper methods that enable
	// developers to easily get userID and RoleID of current user
	//
	//****************************************************************************

	public class AppSecurity
	{																																
		//*********************************************************************
		//
		// AppSecurity.IsInRole() Method
		//
		// The IsInRole method enables developers to easily check the role
		// status of the current browser client.
		//
		//*********************************************************************

		/// <summary>
		/// This method help developers to easily check the role satus of the current user
		/// </summary>
		/// <param name="role">UserRole</param>
		/// <returns>Boolean</returns>
		public static bool IsInRole(string role) 
		{
			return HttpContext.Current.User.IsInRole(role);
		}
		/// <summary>
		///The Encrypt method encrypts a clean string into hashed string 
		/// </summary>
		/// <param name="cleanString">clean string</param>
		/// <returns>hased string</returns>
		public static string Encrypt(string cleanString)
		{
			Byte[] clearBytes = new UnicodeEncoding().GetBytes(cleanString);
			Byte[] hashedBytes = ((HashAlgorithm) CryptoConfig.CreateFromName("MD5")).ComputeHash(clearBytes);
			
			return BitConverter.ToString(hashedBytes);
		}
		/// <summary>
		/// Get userID of current user
		/// </summary>
		/// <returns>UserID</returns>
		public static int GetUserID()
		{
            
			return ((CustomPrincipal)HttpContext.Current.User).UserID;
		}

		/// <summary>
		/// Get role id of the current user
		/// </summary>
		/// <returns>UserRole</returns>
		public static string GetUserRole()
		{
			return ((CustomPrincipal)HttpContext.Current.User).UserRole;
		}

        /// <summary>
        /// Get Organizaiton id of the current user
        /// </summary>
        /// <returns>UserRole</returns>
        public static string GetUserOrganization()
        {
            return ((CustomPrincipal)HttpContext.Current.User).OrganizationID.ToString();
        }
		
		/// <summary>
		/// Validates the input text using a Regular Expression and replaces any input expression
		/// characters with empty string.Removes any characters not in [a-zA-Z0-9_].
		/// </summary>
		/// <param name="inputText">Text to validate</param>
		/// <returns>Sanitized string</returns>
		public static string CleanStringRegex(string inputText)
		{
			RegexOptions options = RegexOptions.IgnoreCase;
			return ReplaceRegex(inputText,@"[^\\.!?""',\-\w\s@]",options);
		}

		/// <summary>
		/// Removes designated characters from an input string input text using a Regular Expression.
		/// </summary>
		/// <remarks>
		/// For a good reference on Regular Expressions, please see
		///	 - http://regexlib.com
		///	 - http://py-howto.sourceforge.net/regex/regex.html
		/// </remarks>
		/// <param name="inputText">The text to clean.</param>
		/// <param name="regularExpression">The regular expression</param>
		/// <returns>Sanitized string.</returns>
		
		private static string ReplaceRegex(string inputText, string regularExpression, RegexOptions options)
		{
			Regex regex = new Regex(regularExpression,options);
			return regex.Replace(inputText,"");
		}
	}
}
