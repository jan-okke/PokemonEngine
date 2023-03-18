using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Rolycoly : Pokemon
	{
		public override string Name => "Rolycoly";
		public override List<Ability> AvailableAbilities => new() {new Steamengine(), new Heatproof() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Flashfire() };
		public override Stats BaseStats => new Stats(30, 40, 50, 40, 50, 30);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Rock };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Tackle(), new Smokescreen() },
			[5] = new List<Move>() { new Rapidspin() },
			[10] = new List<Move>() { new Smackdown() },
			[15] = new List<Move>() { new Rockpolish() },
			[20] = new List<Move>() { new Ancientpower() },
			[25] = new List<Move>() { new Incinerate() },
			[30] = new List<Move>() { new Stealthrock() },
			[35] = new List<Move>() { new Heatcrash() },
			[40] = new List<Move>() { new Rockblast() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Dig(), new Endure(), new Facade(), new Gyroball(), new Heatcrash(), new Hiddenpower(), new Irondefense(), new Ironhead(), new Meteorbeam(), new Protect(), new Reflect(), new Rest(), new Rockblast(), new Rockslide(), new Rocktomb(), new Round(), new Sandstorm(), new Sandtomb(), new Selfdestruct(), new Sleeptalk(), new Snore(), new Spikes(), new Stealthrock(), new Stoneedge(), new Substitute(), new Willowisp() };
		public override List<Move> EggMoves => new List<Move>() { new Block(), new Explosion(), new Mudslap() };
		public override int Weight => 120;
		public override int ExpYield => 48;
		public override int CatchRate => 255;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 1,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}