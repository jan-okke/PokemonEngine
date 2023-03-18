using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Stakataka : Pokemon
	{
		public override string Name => "Stakataka";
		public override List<Ability> AvailableAbilities => new() {new Abilities.Beastboost() };
		public override Stats BaseStats => new Stats(61, 131, 211, 53, 101, 13);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Rock, PokemonType.Steel };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Moves.Tackle(), new Moves.Harden() },
			[5] = new List<Move>() { new Moves.Rockthrow() },
			[10] = new List<Move>() { new Moves.Protect() },
			[15] = new List<Move>() { new Moves.Stomp() },
			[20] = new List<Move>() { new Moves.Block() },
			[25] = new List<Move>() { new Moves.Rockslide() },
			[30] = new List<Move>() { new Moves.Wideguard() },
			[35] = new List<Move>() { new Moves.Autotomize() },
			[40] = new List<Move>() { new Moves.Rockblast() },
			[45] = new List<Move>() { new Moves.Magnetrise() },
			[50] = new List<Move>() { new Moves.Irondefense() },
			[55] = new List<Move>() { new Moves.Ironhead() },
			[60] = new List<Move>() { new Moves.Takedown() },
			[65] = new List<Move>() { new Moves.Stealthrock() },
			[70] = new List<Move>() { new Moves.Doubleedge() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Allyswitch(), new Moves.Bodypress(), new Moves.Bodyslam(), new Moves.Brutalswing(), new Moves.Bulldoze(), new Moves.Earthquake(), new Moves.Endure(), new Moves.Facade(), new Moves.Flashcannon(), new Moves.Gigaimpact(), new Moves.Gyroball(), new Moves.Heatcrash(), new Moves.Heavyslam(), new Moves.Hiddenpower(), new Moves.Highhorsepower(), new Moves.Irondefense(), new Moves.Ironhead(), new Moves.Lightscreen(), new Moves.Magicroom(), new Moves.Megakick(), new Moves.Meteorbeam(), new Moves.Protect(), new Moves.Reflect(), new Moves.Rest(), new Moves.Rockblast(), new Moves.Rockslide(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Safeguard(), new Moves.Sandstorm(), new Moves.Skillswap(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Stealthrock(), new Moves.Steelbeam(), new Moves.Steelroller(), new Moves.Stompingtantrum(), new Moves.Stoneedge(), new Moves.Substitute(), new Moves.Superpower(), new Moves.Trickroom(), new Moves.Wonderroom(), new Moves.Zenheadbutt() };
		public override int Weight => 8200;
		public override int ExpYield => 285;
		public override int CatchRate => 30;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 3,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}