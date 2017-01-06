using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map {

	public Tile[] tiles;
	public int columns;
	public int rows; 

	public void NewMap(int width, int height) {
		columns = width; 
		rows = height; 

		tiles = new Tile[columns * rows];

		CreateTiles ();
	}

	private void CreateTiles() {
		var total = tiles.Length; 

		for (var i = 0; i < total; i++) {
			var tile = new Tile ();
			tile.id = i;
			tiles [i] = tile;
		}

		FindNeighbors ();
	}

	void FindNeighbors(){
		for(var r = 0; r < rows; r++) {
			for(var c = 0; c < columns; c++) {
				var tile = tiles[columns * r + c];

				if(r < rows -1) {
					tile.AddNeighbor(Sides.Bottom, tiles[columns*(r+1)+c]);
				}

				if(c<columns - 1) {
					tile.AddNeighbor(Sides.Right, tiles[columns * r + c + 1]);
				}

				if(c>0) {
					tile.AddNeighbor(Sides.Left, tiles[columns * r + c - 1]);
				}

				if(r>0) {
					tile.AddNeighbor(Sides.Top, tiles[columns * (r-1) + c]);
				}
			}
		}
	}
}
