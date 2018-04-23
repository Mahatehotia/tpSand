﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
	class Walls
	{
		List<Figure> wallList;

		public Walls( int mapWidth, int mapHeight )
		{
			wallList = new List<Figure>();

            // Toto comprend rieng
            DevModeLine devMode = new DevModeLine(0, mapWidth - 2, 0, '-');
            HorizontalLine upLine = new HorizontalLine( 0, mapWidth - 2, 1, '+' );
			HorizontalLine downLine = new HorizontalLine( 0, mapWidth - 2, mapHeight - 1, '+' );
			VerticalLine leftLine = new VerticalLine( 0, mapHeight - 1, 1, '+' );
			VerticalLine rightLine = new VerticalLine( 0, mapHeight - 1, mapWidth - 2, '+' );

            wallList.Add( devMode );
            wallList.Add( upLine );
			wallList.Add( downLine );
			wallList.Add( leftLine );
			wallList.Add( rightLine );
		}

		internal bool IsHit( Figure figure )
		{
			foreach(var wall in wallList)
			{
				if(wall.IsHit(figure))
				{
					return true;
				}
			}
			return false;
		}

		public void Draw()
		{
			foreach ( var wall in wallList )
			{
				wall.Draw();
			}
		}
	}
}
