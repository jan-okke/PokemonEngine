using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Celesteela : Pokemon
	{
		public override string Name => "Celesteela";
		public override List<Ability> AvailableAbilities => new() {new Beastboost() };
		public override Stats BaseStats => new Stats(97, 101, 103, 107, 101, 61);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Steel, PokemonType.Flying };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Absorb(), new Tackle() },
			[5] = new List<Move>() { new Harden() },
			[10] = new List<Move>() { new Wideguard() },
			[15] = new List<Move>() { new Megadrain() },
			[20] = new List<Move>() { new Smackdown() },
			[25] = new List<Move>() { new Ingrain() },
			[30] = new List<Move>() { new Autotomize() },
			[35] = new List<Move>() { new Gigadrain() },
			[40] = new List<Move>() { new Flashcannon() },
			[45] = new List<Move>() { new Metalsound() },
			[50] = new List<Move>() { new Irondefense() },
			[55] = new List<Move>() { new Leechseed() },
			[60] = new List<Move>() { new Heavyslam() },
			[65] = new List<Move>() { new Doubleedge() },
			[70] = new List<Move>() { new Skullbash() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Acrobatics(), new Airslash(), new Bodyslam(), new Brutalswing(), new Bulldoze(), new Earthquake(), new Endure(), new Energyball(), new Facade(), new Fireblast(), new Flamethrower(), new Flashcannon(), new Fly(), new Gigadrain(), new Gigaimpact(), new Grassknot(), new Gyroball(), new Heavyslam(), new Hiddenpower(), new Hyperbeam(), new Irondefense(), new Ironhead(), new Megahorn(), new Meteorbeam(), new Protect(), new Rest(), new Rockslide(), new Round(), new Seedbomb(), new Selfdestruct(), new Sleeptalk(), new Smartstrike(), new Snore(), new Solarbeam(), new Steelbeam(), new Steelroller(), new Stompingtantrum(), new Stoneedge(), new Substitute(), new Superpower(), new Zenheadbutt() };
		public override int Weight => 9999;
		public override int ExpYield => 285;
		public override int CatchRate => 45;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 1,
			[Stat.Defense] = 1,
			[Stat.SpecialAttack] = 1,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}