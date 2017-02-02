# LRDL2
##Design Philosophy
LRDL2 is a roguelike engine designed to give developers a template to use for their own custom roguelikes. In roguelike fashion, the engine is built for games using the console window, though output for other formats that could be more easily plugged into a GUI might be useful down the road as well. The base engine will include basics for creating maps, adding layers, loot, enemies, player control, and a longest-lived/high score table. The engine will be based on “tiles” which are essentially blocks of content that serve as the basic unit of the game’s movement and display. One tile may be a wall, or another, a section of floor. A tile might also contain things, such as a your player, a monster, a fellow traveler, or loot.<br />
##To do (under construction)
- [x] Added Tile class (via interface)
- [x] Added TileMap class 
- [x] Added Player class
- [x] Added MainMapViewModel class (via interface)
- [x] Added MainMapView class (via interface)
- [x] Added MVC (with interfaces for models, a view, and a controller)
- [x] Added Services Layer class (via interface)