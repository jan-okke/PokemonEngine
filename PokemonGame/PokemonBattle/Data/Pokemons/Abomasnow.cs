using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Abomasnow : Pokemon
	{
		public override string Name => "Abomasnow";
		public override List<Ability> AvailableAbilities => new() {new Snowwarning() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Soundproof() };
		public override Stats BaseStats => new Stats(90, 92, 75, 92, 85, 60);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Grass, PokemonType.Ice };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Icepunch() },
			[1] = new List<Move>() { new Icepunch(), new Auroraveil(), new Powdersnow(), new Leer(), new Leafage(), new Mist() },
			[15] = new List<Move>() { new Iceshard() },
			[20] = new List<Move>() { new Razorleaf() },
			[25] = new List<Move>() { new Icywind() },
			[30] = new List<Move>() { new Swagger() },
			[35] = new List<Move>() { new Ingrain() },
			[43] = new List<Move>() { new Woodhammer() },
			[49] = new List<Move>() { new Blizzard() },
			[56] = new List<Move>() { new Sheercold() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Avalanche(), new Blizzard(), new Brickbreak(), new Bulldoze(), new Bulletseed(), new Doubleteam(), new Earthpower(), new Earthquake(), new Endure(), new Energyball(), new Facade(), new Flash(), new Fling(), new Focusblast(), new Focuspunch(), new Gigadrain(), new Gigaimpact(), new Grassknot(), new Grassyglide(), new Hail(), new Hiddenpower(), new Hyperbeam(), new Icebeam(), new Icepunch(), new Iciclespear(), new Icywind(), new Irontail(), new Leafstorm(), new Lightscreen(), new Magicalleaf(), new Megakick(), new Megapunch(), new Outrage(), new Protect(), new Raindance(), new Rest(), new Rockclimb(), new Rockslide(), new Rocksmash(), new Rocktomb(), new Round(), new Safeguard(), new Seedbomb(), new Shadowball(), new Sleeptalk(), new Snore(), new Solarbeam(), new Stompingtantrum(), new Strength(), new Substitute(), new Swagger(), new Swordsdance(), new Waterpulse(), new Weatherball() };
		public override int Weight => 1355;
		public override int ExpYield => 173;
		public override int CatchRate => 60;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 1,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 1,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}