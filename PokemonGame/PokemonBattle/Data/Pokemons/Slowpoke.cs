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
		public override List<Ability> AvailableAbilities => new() {new Abilities.Oblivious(), new Abilities.Owntempo() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Regenerator() };
		public override Stats BaseStats => new Stats(90, 65, 65, 40, 40, 15);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Water, PokemonType.Psychic };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Moves.Tackle(), new Moves.Curse() },
			[3] = new List<Move>() { new Moves.Growl() },
			[6] = new List<Move>() { new Moves.Watergun() },
			[9] = new List<Move>() { new Moves.Yawn() },
			[12] = new List<Move>() { new Moves.Confusion() },
			[15] = new List<Move>() { new Moves.Disable() },
			[18] = new List<Move>() { new Moves.Waterpulse() },
			[21] = new List<Move>() { new Moves.Headbutt() },
			[24] = new List<Move>() { new Moves.Zenheadbutt() },
			[27] = new List<Move>() { new Moves.Amnesia() },
			[30] = new List<Move>() { new Moves.Surf() },
			[33] = new List<Move>() { new Moves.Slackoff() },
			[36] = new List<Move>() { new Moves.Psychic() },
			[39] = new List<Move>() { new Moves.Psychup() },
			[42] = new List<Move>() { new Moves.Raindance() },
			[45] = new List<Move>() { new Moves.Healpulse() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Amnesia(), new Moves.Attract(), new Moves.Blizzard(), new Moves.Bodyslam(), new Moves.Brine(), new Moves.Bulldoze(), new Moves.Calmmind(), new Moves.Dig(), new Moves.Dive(), new Moves.Doubleteam(), new Moves.Dreameater(), new Moves.Earthquake(), new Moves.Endure(), new Moves.Expandingforce(), new Moves.Facade(), new Moves.Fireblast(), new Moves.Flamethrower(), new Moves.Flash(), new Moves.Futuresight(), new Moves.Grassknot(), new Moves.Hail(), new Moves.Hiddenpower(), new Moves.Hydropump(), new Moves.Icebeam(), new Moves.Icywind(), new Moves.Imprison(), new Moves.Irontail(), new Moves.Lightscreen(), new Moves.Liquidation(), new Moves.Mudshot(), new Moves.Payday(), new Moves.Protect(), new Moves.Psychic(), new Moves.Psychicterrain(), new Moves.Psychup(), new Moves.Psyshock(), new Moves.Raindance(), new Moves.Recycle(), new Moves.Rest(), new Moves.Round(), new Moves.Safeguard(), new Moves.Scald(), new Moves.Shadowball(), new Moves.Skillswap(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Storedpower(), new Moves.Strength(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Surf(), new Moves.Swagger(), new Moves.Swift(), new Moves.Thunderwave(), new Moves.Triattack(), new Moves.Trick(), new Moves.Trickroom(), new Moves.Waterpulse(), new Moves.Weatherball(), new Moves.Whirlpool(), new Moves.Wonderroom(), new Moves.Zenheadbutt() };
		public override List<Move> EggMoves => new List<Move>() { new Moves.Belch(), new Moves.Bellydrum(), new Moves.Block(), new Moves.Futuresight(), new Moves.Snore(), new Moves.Stomp(), new Moves.Wonderroom(), new Moves.Zenheadbutt() };
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