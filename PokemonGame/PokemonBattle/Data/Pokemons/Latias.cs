using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Latias : Pokemon
{
	public override string Name => "Latias";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Levitate() };
	public override Stats BaseStats => new Stats(80, 80, 90, 110, 130, 110);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
	public override List<PokemonType> Types => new() {PokemonType.Dragon, PokemonType.Psychic };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Storedpower(), new Moves.Charm() },
		[5] = new List<Move>() { new Moves.Helpinghand() },
		[10] = new List<Move>() { new Moves.Recover() },
		[15] = new List<Move>() { new Moves.Confusion() },
		[20] = new List<Move>() { new Moves.Tailwind() },
		[25] = new List<Move>() { new Moves.Dragonbreath() },
		[30] = new List<Move>() { new Moves.Wish() },
		[35] = new List<Move>() { new Moves.Mistball() },
		[40] = new List<Move>() { new Moves.Zenheadbutt() },
		[45] = new List<Move>() { new Moves.Dragonpulse() },
		[50] = new List<Move>() { new Moves.Healpulse() },
		[55] = new List<Move>() { new Moves.Reflecttype() },
		[60] = new List<Move>() { new Moves.Psychic() },
		[65] = new List<Move>() { new Moves.Guardsplit() },
		[70] = new List<Move>() { new Moves.Healingwish() },
		[75] = new List<Move>() { new Moves.Psychoshift() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Aerialace(), new Moves.Agility(), new Moves.Airslash(), new Moves.Allyswitch(), new Moves.Attract(), new Moves.Aurasphere(), new Moves.Batonpass(), new Moves.Bodyslam(), new Moves.Breakingswipe(), new Moves.Bulldoze(), new Moves.Calmmind(), new Moves.Chargebeam(), new Moves.Charm(), new Moves.Cut(), new Moves.Defog(), new Moves.Dive(), new Moves.Doubleteam(), new Moves.Dracometeor(), new Moves.Dragonclaw(), new Moves.Dragondance(), new Moves.Dragonpulse(), new Moves.Dreameater(), new Moves.Dualwingbeat(), new Moves.Earthquake(), new Moves.Endure(), new Moves.Energyball(), new Moves.Facade(), new Moves.Flash(), new Moves.Fly(), new Moves.Futuresight(), new Moves.Gigaimpact(), new Moves.Grassknot(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Icebeam(), new Moves.Icywind(), new Moves.Lightscreen(), new Moves.Magicroom(), new Moves.Mysticalfire(), new Moves.Outrage(), new Moves.Protect(), new Moves.Psychic(), new Moves.Psychocut(), new Moves.Psychup(), new Moves.Psyshock(), new Moves.Raindance(), new Moves.Reflect(), new Moves.Rest(), new Moves.Retaliate(), new Moves.Roar(), new Moves.Roost(), new Moves.Round(), new Moves.Safeguard(), new Moves.Sandstorm(), new Moves.Scaleshot(), new Moves.Shadowball(), new Moves.Shadowclaw(), new Moves.Shockwave(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Steelwing(), new Moves.Storedpower(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Surf(), new Moves.Swagger(), new Moves.Swift(), new Moves.Thunder(), new Moves.Thunderbolt(), new Moves.Thunderwave(), new Moves.Triattack(), new Moves.Trick(), new Moves.Waterfall(), new Moves.Waterpulse(), new Moves.Whirlpool(), new Moves.Zenheadbutt() };
	public override int Weight => 400;
	public override int ExpYield => 300;
	public override int CatchRate => 3;
	public override Dictionary<Stat, int> EVYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 0,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 3,
		[Stat.Speed] = 0
	};
}