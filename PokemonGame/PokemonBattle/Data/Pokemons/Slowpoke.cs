using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Slowpoke : Pokemon
	{
		public override string Name => "Slowpoke";
		public override List<Ability> AvailableAbilities => new() {new Oblivious(), new Owntempo() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Regenerator() };
		public override Stats BaseStats => new Stats(90, 65, 65, 15, 40, 40);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Water, PokemonType.Psychic };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Tackle(), new Curse() },
			[3] = new List<Move>() { new Growl() },
			[6] = new List<Move>() { new Watergun() },
			[9] = new List<Move>() { new Yawn() },
			[12] = new List<Move>() { new Confusion() },
			[15] = new List<Move>() { new Disable() },
			[18] = new List<Move>() { new Waterpulse() },
			[21] = new List<Move>() { new Headbutt() },
			[24] = new List<Move>() { new Zenheadbutt() },
			[27] = new List<Move>() { new Amnesia() },
			[30] = new List<Move>() { new Surf() },
			[33] = new List<Move>() { new Slackoff() },
			[36] = new List<Move>() { new Psychic() },
			[39] = new List<Move>() { new Psychup() },
			[42] = new List<Move>() { new Raindance() },
			[45] = new List<Move>() { new Healpulse() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Amnesia(), new Attract(), new Blizzard(), new Bodyslam(), new Brine(), new Bulldoze(), new Calmmind(), new Dig(), new Dive(), new Doubleteam(), new Dreameater(), new Earthquake(), new Endure(), new Expandingforce(), new Facade(), new Fireblast(), new Flamethrower(), new Flash(), new Futuresight(), new Grassknot(), new Hail(), new Hiddenpower(), new Hydropump(), new Icebeam(), new Icywind(), new Imprison(), new Irontail(), new Lightscreen(), new Liquidation(), new Mudshot(), new Payday(), new Protect(), new Psychic(), new Psychicterrain(), new Psychup(), new Psyshock(), new Raindance(), new Recycle(), new Rest(), new Round(), new Safeguard(), new Scald(), new Shadowball(), new Skillswap(), new Sleeptalk(), new Snore(), new Storedpower(), new Strength(), new Substitute(), new Sunnyday(), new Surf(), new Swagger(), new Swift(), new Thunderwave(), new Triattack(), new Trick(), new Trickroom(), new Waterpulse(), new Weatherball(), new Whirlpool(), new Wonderroom(), new Zenheadbutt() };
		public override List<Move> EggMoves => new List<Move>() { new Belch(), new Bellydrum(), new Block(), new Futuresight(), new Snore(), new Stomp(), new Wonderroom(), new Zenheadbutt() };
		public override int Weight => 360;
		public override int ExpYield => 63;
		public override int CatchRate => 190;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 1,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}