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

	public partial class MainForm : BaseForm {

		#region Constructors.
		public MainForm() {
			InitializeComponent();
		} // MainForm
		#endregion

		#region Override and event handling methods.
		/// <summary>
		/// Initialize the application and form.
		/// </summary>
		protected override void OnLoad(EventArgs e) {
			// Invoke base method.
			base.OnLoad(e);

			// Initialize the form.
			this.OnLog += OnLogHandler;
			this.pluginList.Format += this.PluginListFormat;
			this.pluginList.DataSource = this.GetPlugins();

			// Log.
			this.Log("The form is initialized.");
		} // OnLoad

		/// <summary>
		/// Format the display text in the plugin list.
		/// </summary>
		/// <param name="sender">The sender.</param>
		/// <param name="e">The event arguments.</param>
		private void PluginListFormat(Object sender, ListControlConvertEventArgs e) {
			try {
				IPlugin plugin = (IPlugin)e.ListItem;
				e.Value = String.Format("{0}  {1}", plugin.GetGuid(), plugin.GetName());
			} catch { }
		} // PluginListFormat

		/// <summary>
		/// Invoke the Run method on the selected plugin.
		/// </summary>
		/// <param name="sender">The sender.</param>
		/// <param name="e">The event arguments.</param>
		private void PluginRunClick(Object sender, EventArgs e) {
			// Disable controls.
			pluginList.Enabled = false;
			pluginRun.Enabled = false;

			// Run the plugin.
			this.Log("Application: The plugin execution is starting.");
			try {
				((IPlugin)this.pluginList.SelectedItem).Run();
			} catch (Exception exception) {
				this.LogError(exception);
			}
			this.Log("Application: The plugin execution has ended.");

			// Enable controls.
			pluginRun.Enabled = true;
			pluginList.Enabled = true;
		} // PluginRunClick

		/// <summary>
		/// Appent the formatted text to the log.
		/// </summary>
		/// <param name="logFlags">The log flags.</param>
		/// <param name="text">The log text.</param>
		/// <param name="formattedText">The formatted log text.</param>
		private void OnLogHandler(LoggerFlags logFlags, String text, String formattedText) {
			// Append the formatted text to the log.
			this.logText.AppendText(formattedText + Environment.NewLine);
		} // OnLogHandler
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