using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Dwebble : Pokemon
	{
		public override string Name => "Dwebble";
		public override List<Ability> AvailableAbilities => new() {new Sturdy(), new Shellarmor() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Weakarmor() };
		public override Stats BaseStats => new Stats(50, 65, 85, 55, 35, 35);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Bug, PokemonType.Rock };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Furycutter(), new Sandattack() },
			[4] = new List<Move>() { new Withdraw() },
			[8] = new List<Move>() { new Smackdown() },
			[12] = new List<Move>() { new Bugbite() },
			[16] = new List<Move>() { new Flail() },
			[20] = new List<Move>() { new Slash() },
			[24] = new List<Move>() { new Rockslide() },
			[28] = new List<Move>() { new Stealthrock() },
			[32] = new List<Move>() { new Rockblast() },
			[36] = new List<Move>() { new Xscissor() },
			[40] = new List<Move>() { new Rockpolish() },
			[44] = new List<Move>() { new Shellsmash() },
			[48] = new List<Move>() { new Rockwrecker() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Bulldoze(), new Dig(), new Earthquake(), new Endure(), new Facade(), new Hiddenpower(), new Irondefense(), new Poisonjab(), new Protect(), new Rest(), new Rockblast(), new Rockslide(), new Rocktomb(), new Round(), new Sandstorm(), new Sandtomb(), new Shadowclaw(), new Skittersmack(), new Sleeptalk(), new Snore(), new Solarbeam(), new Spikes(), new Stealthrock(), new Stoneedge(), new Substitute(), new Swordsdance(), new Xscissor() };
		public override List<Move> EggMoves => new List<Move>() { new Block(), new Counter(), new Curse(), new Knockoff(), new Nightslash(), new Wideguard() };
		public override int Weight => 145;
		public override int ExpYield => 65;
		public override int CatchRate => 190;
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