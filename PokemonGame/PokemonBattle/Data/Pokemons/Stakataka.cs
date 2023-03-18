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
		public override List<Ability> AvailableAbilities => new() {new Beastboost() };
		public override Stats BaseStats => new Stats(61, 131, 211, 13, 53, 101);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Rock, PokemonType.Steel };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Tackle(), new Harden() },
			[5] = new List<Move>() { new Rockthrow() },
			[10] = new List<Move>() { new Protect() },
			[15] = new List<Move>() { new Stomp() },
			[20] = new List<Move>() { new Block() },
			[25] = new List<Move>() { new Rockslide() },
			[30] = new List<Move>() { new Wideguard() },
			[35] = new List<Move>() { new Autotomize() },
			[40] = new List<Move>() { new Rockblast() },
			[45] = new List<Move>() { new Magnetrise() },
			[50] = new List<Move>() { new Irondefense() },
			[55] = new List<Move>() { new Ironhead() },
			[60] = new List<Move>() { new Takedown() },
			[65] = new List<Move>() { new Stealthrock() },
			[70] = new List<Move>() { new Doubleedge() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Allyswitch(), new Bodypress(), new Bodyslam(), new Brutalswing(), new Bulldoze(), new Earthquake(), new Endure(), new Facade(), new Flashcannon(), new Gigaimpact(), new Gyroball(), new Heatcrash(), new Heavyslam(), new Hiddenpower(), new Highhorsepower(), new Irondefense(), new Ironhead(), new Lightscreen(), new Magicroom(), new Megakick(), new Meteorbeam(), new Protect(), new Reflect(), new Rest(), new Rockblast(), new Rockslide(), new Rocktomb(), new Round(), new Safeguard(), new Sandstorm(), new Skillswap(), new Sleeptalk(), new Snore(), new Stealthrock(), new Steelbeam(), new Steelroller(), new Stompingtantrum(), new Stoneedge(), new Substitute(), new Superpower(), new Trickroom(), new Wonderroom(), new Zenheadbutt() };
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