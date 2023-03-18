using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Crustle : Pokemon
	{
		public override string Name => "Crustle";
		public override List<Ability> AvailableAbilities => new() {new Abilities.Sturdy(), new Abilities.Shellarmor() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Weakarmor() };
		public override Stats BaseStats => new Stats(70, 105, 125, 65, 75, 45);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Bug, PokemonType.Rock };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Moves.Furycutter(), new Moves.Sandattack(), new Moves.Withdraw(), new Moves.Smackdown() },
			[12] = new List<Move>() { new Moves.Bugbite() },
			[16] = new List<Move>() { new Moves.Flail() },
			[20] = new List<Move>() { new Moves.Slash() },
			[24] = new List<Move>() { new Moves.Rockslide() },
			[28] = new List<Move>() { new Moves.Stealthrock() },
			[32] = new List<Move>() { new Moves.Rockblast() },
			[38] = new List<Move>() { new Moves.Xscissor() },
			[44] = new List<Move>() { new Moves.Rockpolish() },
			[50] = new List<Move>() { new Moves.Shellsmash() },
			[56] = new List<Move>() { new Moves.Rockwrecker() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Attract(), new Moves.Bodypress(), new Moves.Bulldoze(), new Moves.Dig(), new Moves.Earthquake(), new Moves.Endure(), new Moves.Facade(), new Moves.Gigaimpact(), new Moves.Heavyslam(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Irondefense(), new Moves.Meteorbeam(), new Moves.Poisonjab(), new Moves.Protect(), new Moves.Rest(), new Moves.Rockblast(), new Moves.Rockslide(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Sandstorm(), new Moves.Sandtomb(), new Moves.Shadowclaw(), new Moves.Skittersmack(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Solarblade(), new Moves.Spikes(), new Moves.Stealthrock(), new Moves.Stompingtantrum(), new Moves.Stoneedge(), new Moves.Substitute(), new Moves.Swordsdance(), new Moves.Xscissor() };
		public override int Weight => 2000;
		public override int ExpYield => 170;
		public override int CatchRate => 75;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 2,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}