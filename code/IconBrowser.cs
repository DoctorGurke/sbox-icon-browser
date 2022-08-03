using Sandbox;
using System;
using System.Linq;
using Tools;

public class feeffe
{
	[Dock( "Editor", "Icon Browser", "control_point" )]
	public class IconBrowser : Widget
	{
		ListView ListView;
		ToolButton ViewMode;

		private Settings Settings;
		private const string SettingsPrefix = "doctor.icons_tool.settings";

		int _viewModeType;
		public int ViewModeType
		{
			get => _viewModeType;
			set
			{
				if ( _viewModeType == value ) return;
				_viewModeType = value;

				Settings.Save( "icon_size", _viewModeType );
				UpdateIconSize( _viewModeType );

				if ( value == 1 ) ViewMode.Icon = "apps";
				if ( value == 2 ) ViewMode.Icon = "grid_on";
				if ( value == 3 ) ViewMode.Icon = "grid_view";
			}
		}

		public IconBrowser( Widget parent ) : base( parent )
		{
			// init settings
			Settings = new( SettingsPrefix );

			SetLayout( LayoutMode.TopToBottom );
			Layout.Spacing = 0;

			var top = Layout.AddRow();

			var tb = top.Add( new ToolBar( this ) );

			var filter = new LineEdit();
			filter.PlaceholderText = "Filter..";
			filter.TextChanged += OnFilterTextChanged;
			tb.AddWidget( filter );

			ViewMode = top.Add( new ToolButton( "Icon Size", "grid_on", this ) );
			ViewMode.MouseLeftPress = () =>
			{
				var menu = new Menu( this );

				menu.AddOption( "Small Icons", "apps", () => ViewModeType = 1 );
				menu.AddOption( "Medium Icons", "grid_on", () => ViewModeType = 2 );
				menu.AddOption( "Large Icons", "grid_view", () => ViewModeType = 3 );

				menu.OpenAt( ViewMode.ScreenRect.BottomLeft, false );
			};

			ListView = new ListView( this );

			Layout.Add( ListView, 1 );

			var icons = Enum.GetValues<MaterialIcon>();

			ListView.SetItems( icons.Select( x => (object)x ) );
			ListView.ItemPaint = PaintItem;
			ListView.ItemSelected = OnItemSelected;

			ViewModeType = Settings.Load( "icon_size", ViewModeType );
			UpdateIconSize( ViewModeType );
		}

		private void OnFilterTextChanged( string filter )
		{
			ListView.SetItems( Enum.GetValues<MaterialIcon>().Where( x => string.IsNullOrEmpty( filter ) || x.ToString().Contains( filter, StringComparison.OrdinalIgnoreCase ) ).Select( x => (object)x ) );
		}

		private void UpdateIconSize( int i )
		{
			var size = i switch
			{
				1 => 32,
				2 => 64,
				3 => 128,
				_ => 64
			};

			ListView.ItemSize = size;
		}

		private object _last;
		private object _copy;
		private RealTimeSince _delay;

		private void OnItemSelected( object obj )
		{
			if ( obj is not MaterialIcon icon ) return;

			var name = MaterialIconUtility.Lookup( icon );

			// only tell us the icon if we hadn't had it selected last
			if ( _last != obj )
			{
				Log.Info( $"{obj} \"{name}\"" );
				_last = obj;
				_delay = 0;
				return;
			}

			// double click check
			if ( _delay > 0.5f )
			{
				_delay = 0;
				return;
			}

			// only copy this item once, any more double clicks should not do anything
			if ( _copy != _last )
			{
				Log.Info( $"\"{name}\" copied to clipboard." );
				Clipboard.Copy( $"{name}" );
				_copy = obj;
			}

			_delay = 0;
		}

		private void PaintItem( VirtualWidget item )
		{
			if ( item.Object is not MaterialIcon icon ) return;

			var name = MaterialIconUtility.Lookup( icon );

			if ( Paint.HasSelected || Paint.HasPressed )
			{
				Paint.SetPen( Paint.HasPressed ? Theme.Green : Theme.Primary, 2, PenStyle.Dash );
				Paint.ClearBrush();
				Paint.DrawRect( item.Rect.Contract( 1 ), 3 );

				Paint.ClearPen();
				Paint.SetBrush( Paint.HasPressed ? Theme.Green.WithAlpha( 0.4f ) : Theme.Primary.WithAlpha( 0.4f ) );
				Paint.DrawRect( item.Rect.Contract( 0 ), 3 );

				Paint.SetPen( Theme.White );
			}
			else if ( Paint.HasMouseOver )
			{
				Paint.ClearPen();
				Paint.SetBrush( Theme.Blue.Darken( 0.7f ).Desaturate( 0.3f ).WithAlpha( 0.5f ) );
				Paint.DrawRect( item.Rect.Expand( -2.0f ) );
				Paint.SetPen( Theme.White );
			}
			else
			{
				Paint.SetPen( Theme.White.WithAlpha( 0.7f ) );
			}

			// draw icon
			Paint.SetPen( Theme.White.WithAlpha( 0.5f ) );
			Paint.DrawIcon( item.Rect, $"{name}", item.Rect.height - 4 );
		}
	}
}
