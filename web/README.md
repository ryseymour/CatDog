# CatDog: browser edition

A playable browser version of CatDog, the 2017 Unity + Fungus lane battler. Open `index.html` through any static web server (for example `python3 -m http.server` in this folder) and pick a kingdom.

## What's in it

- **Both kingdoms.** Play the Cats (blue fleas, cat mages, scratching-post castle) or the Dogs (red fleas, dog wizards, bone fortress).
- **Three story chapters, three battles, and the epilogue.** This follows `OurSceneManager`'s plan (narrative, game, narrative, game, narrative) with one extra battle so each chapter leads into a war.
- **The original dialogue.** Every line in `story.js` comes from the Fungus flowcharts in `Assets/1Che Dialogue Scenes`, with spelling fixed. The three intro lines are new, because the original intro scene (`Level0`) only had placeholder text.
- **Choices that matter.** Each choice sides with Mom (+1) or Dad (-1), and each chapter ends with the original "decision tally". Mom's help makes your castle and towers tougher, gives your towers more damage and range. Dad's help gives your troops more health and damage. In the Unity build only the attack half was wired up (`FungusManager.attack`); defense was never used.
- **The original art.** The mage, flea, siege cart, castle, tower, tree, rock and coin models (`Assets/Rehaf-assets/models`) with their walk, attack and death animations, and the parents' expression portraits for both kingdoms.
- **Lane battles.** Pick a gate (Left, Center, Right, like `shop.cs`), buy Fleas (3), Mages (5) or Siege carts (10). Coins tick up over time and for kills. Siege carts ignore troops and go for towers and the castle. Enemy troops pick a gate at random (25% left, 25% right, 50% center, as in `EnemyPlayerScript`).
- **Maps from the original scenes.** Each battle is laid out from the waypoint chains in the Unity levels. Battle 1 (`CLevel2`/`DLevel2`) has a straight center road and two wide U-shaped flank roads. Battle 2 (`CLevel4`/`DLevel4`) has bent flank roads and the enemy outpost behind your castle (the second spawner and its turrets), which sends raiders down a rear road until you burn its towers. Battle 3 is new: the same map with every outpost tower manned. On wide screens a long map is shown from the side, as in the original.

Controls: A/S/D or the arrow keys pick a gate (W for the rear gate when there is one), 1/2/3 buy troops, P pauses. Tap the field to pick the nearest lane; with a mouse, pointing at a road lights it up first, like the original's path cubes. The win and loss cards show a short battle summary. In dialogue, click, Space or Enter advances; "Skip to choice" jumps ahead.

## Story fixes

- Chapter 1's "tell your mother / tell your father" scene was only wired in on the Dog side; both sides get it now.
- Chapter 2 uses the Dog side's unused "OffenseOrDefense" and "BrisOrBallet" scenes. Their menu targets were swapped (choosing "Offense" counted for Mom), which is fixed.
- A few lines had no speaker set in Fungus; the speaker was inferred from context.
- Sister, Brother and You use simple drawn badges instead of the stock-photo placeholders in `Assets/CatPractice`.

## Files

- `index.html`: the game (Three.js 0.160 from jsDelivr).
- `story.js`: the dialogue script.
- `art.js`, `models.js`: generated from the Unity assets. Rebuild them with `python3 web/tools/build-art.py` (needs Pillow), then `cd web/tools && npm i three@0.160.0 playwright && node export-models.mjs`.

Progress is saved in the browser, so you can continue where you left off.
