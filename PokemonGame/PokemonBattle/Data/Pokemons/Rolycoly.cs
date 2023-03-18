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
		public override List<Ability> AvailableAbilities => new() {new Abilities.Steamengine(), new Abilities.Heatproof() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Flashfire() };
		public override Stats BaseStats => new Stats(30, 40, 50, 40, 50, 30);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Rock };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Moves.Tackle(), new Moves.Smokescreen() },
			[5] = new List<Move>() { new Moves.Rapidspin() },
			[10] = new List<Move>() { new Moves.Smackdown() },
			[15] = new List<Move>() { new Moves.Rockpolish() },
			[20] = new List<Move>() { new Moves.Ancientpower() },
			[25] = new List<Move>() { new Moves.Incinerate() },
			[30] = new List<Move>() { new Moves.Stealthrock() },
			[35] = new List<Move>() { new Moves.Heatcrash() },
			[40] = new List<Move>() { new Moves.Rockblast() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Attract(), new Moves.Dig(), new Moves.Endure(), new Moves.Facade(), new Moves.Gyroball(), new Moves.Heatcrash(), new Moves.Hiddenpower(), new Moves.Irondefense(), new Moves.Ironhead(), new Moves.Meteorbeam(), new Moves.Protect(), new Moves.Reflect(), new Moves.Rest(), new Moves.Rockblast(), new Moves.Rockslide(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Sandstorm(), new Moves.Sandtomb(), new Moves.Selfdestruct(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Spikes(), new Moves.Stealthrock(), new Moves.Stoneedge(), new Moves.Substitute(), new Moves.Willowisp() };
		public override List<Move> EggMoves => new List<Move>() { new Moves.Block(), new Moves.Explosion(), new Moves.Mudslap() };
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