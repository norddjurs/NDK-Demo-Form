using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NDK.Framework;

namespace NDK.DemoForm {
	public partial class MainForm : PluginForm {

		#region Constructors.
		public MainForm() {
			InitializeComponent();
		} // MainForm
		#endregion

		#region Override methods.
		/// <summary>
		/// Initialize the application.
		/// </summary>
		protected override void OnLoad(EventArgs e) {
			// Invoke base method.
			base.OnLoad(e);

			// Log.
			this.Log("The form is initialized.");
		} // OnLoad
		#endregion

		#region Abstract and Virtual methods.
		/// <summary>
		/// Gets the unique form guid used when referencing resources.
		/// When implementing a form, this method should return the same unique guid every time. 
		/// </summary>
		/// <returns></returns>
		public override Guid GetGuid() {
			return new Guid("{9A19BE2F-6ADB-4BC3-B8B5-E2AA28A50F70}");
		} // GetGuid

		/// <summary>
		/// Gets the the form name.
		/// When implementing a form, this method should return a proper display name.
		/// </summary>
		/// <returns></returns>
		public override String GetName() {
			return "NDK Framework Demo Form";
		} // GetName
		#endregion

		#region Static main methods.
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		public static void Main() {
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm());
		} // Main
		#endregion

	} // MainForm

} // NDK.DemoForm