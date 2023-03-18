using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Melmetal : Pokemon
	{
		public override string Name => "Melmetal";
		public override List<Ability> AvailableAbilities => new() {new Ironfist() };
		public override Stats BaseStats => new Stats(135, 143, 143, 80, 65, 34);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Steel };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Thunderpunch() },
			[1] = new List<Move>() { new Thunderpunch(), new Thundershock(), new Harden(), new Tailwhip(), new Headbutt() },
			[24] = new List<Move>() { new Thunderwave() },
			[32] = new List<Move>() { new Acidarmor() },
			[40] = new List<Move>() { new Flashcannon() },
			[48] = new List<Move>() { new Megapunch() },
			[56] = new List<Move>() { new Protect() },
			[64] = new List<Move>() { new Discharge() },
			[72] = new List<Move>() { new Dynamicpunch() },
			[80] = new List<Move>() { new Superpower() },
			[88] = new List<Move>() { new Doubleironbash() },
			[96] = new List<Move>() { new Hyperbeam() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Bodypress(), new Bodyslam(), new Brickbreak(), new Brutalswing(), new Darkestlariat(), new Earthquake(), new Electricterrain(), new Endure(), new Facade(), new Flashcannon(), new Gigaimpact(), new Gyroball(), new Heavyslam(), new Hiddenpower(), new Highhorsepower(), new Hyperbeam(), new Icebeam(), new Icepunch(), new Irondefense(), new Ironhead(), new Megakick(), new Megapunch(), new Protect(), new Rest(), new Rockslide(), new Rocktomb(), new Round(), new Selfdestruct(), new Sleeptalk(), new Snore(), new Solarbeam(), new Steelbeam(), new Steelroller(), new Substitute(), new Superpower(), new Thunder(), new Thunderbolt(), new Thunderpunch(), new Thunderwave() };
		public override int Weight => 8000;
		public override int ExpYield => 300;
		public override int CatchRate => 3;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 3,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}