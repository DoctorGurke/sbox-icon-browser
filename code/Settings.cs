namespace Sandbox
{
	public class Settings
	{
		private string SettingsPrefix { get; set; }

		public Settings( string prefix )
		{
			SettingsPrefix = prefix;
		}

		public void Save<T>( string name, T value )
		{
			Cookie.Set<T>( $"{SettingsPrefix}.{name}", value );
		}

		public T Load<T>( string name, T fallback )
		{
			return Cookie.Get<T>( $"{SettingsPrefix}.{name}", fallback );
		}
	}
}
