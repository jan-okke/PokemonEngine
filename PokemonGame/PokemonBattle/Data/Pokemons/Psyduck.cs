using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Psyduck : Pokemon
	{
		public override string Name => "Psyduck";
		public override List<Ability> AvailableAbilities => new() {new Damp(), new Cloudnine() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Swiftswim() };
		public override Stats BaseStats => new Stats(50, 52, 48, 65, 50, 55);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Water };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Scratch(), new Tailwhip() },
			[3] = new List<Move>() { new Watergun() },
			[6] = new List<Move>() { new Confusion() },
			[9] = new List<Move>() { new Furyswipes() },
			[12] = new List<Move>() { new Waterpulse() },
			[15] = new List<Move>() { new Disable() },
			[18] = new List<Move>() { new Zenheadbutt() },
			[21] = new List<Move>() { new Screech() },
			[24] = new List<Move>() { new Aquatail() },
			[27] = new List<Move>() { new Soak() },
			[30] = new List<Move>() { new Psychup() },
			[34] = new List<Move>() { new Amnesia() },
			[36] = new List<Move>() { new Hydropump() },
			[39] = new List<Move>() { new Wonderroom() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Aerialace(), new Amnesia(), new Attract(), new Blizzard(), new Bodyslam(), new Brickbreak(), new Brine(), new Calmmind(), new Dig(), new Dive(), new Doubleteam(), new Encore(), new Endure(), new Facade(), new Flash(), new Fling(), new Focuspunch(), new Futuresight(), new Hail(), new Hiddenpower(), new Hydropump(), new Icebeam(), new Icepunch(), new Icywind(), new Irontail(), new Lightscreen(), new Megakick(), new Megapunch(), new Payday(), new Protect(), new Psychic(), new Psychup(), new Psyshock(), new Raindance(), new Rest(), new Rocksmash(), new Round(), new Scald(), new Screech(), new Shadowclaw(), new Sleeptalk(), new Snore(), new Strength(), new Substitute(), new Surf(), new Swagger(), new Swift(), new Waterfall(), new Waterpulse(), new Whirlpool(), new Wonderroom(), new Zenheadbutt() };
		public override List<Move> EggMoves => new List<Move>() { new Clearsmog(), new Confuseray(), new Crosschop(), new Encore(), new Futuresight(), new Hypnosis(), new Psybeam(), new Simplebeam(), new Yawn() };
		public override int Weight => 196;
		public override int ExpYield => 64;
		public override int CatchRate => 190;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 1,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}