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
		public override List<Ability> AvailableAbilities => new() {new Sturdy(), new Shellarmor() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Weakarmor() };
		public override Stats BaseStats => new Stats(70, 105, 125, 45, 65, 75);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Bug, PokemonType.Rock };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Furycutter(), new Sandattack(), new Withdraw(), new Smackdown() },
			[12] = new List<Move>() { new Bugbite() },
			[16] = new List<Move>() { new Flail() },
			[20] = new List<Move>() { new Slash() },
			[24] = new List<Move>() { new Rockslide() },
			[28] = new List<Move>() { new Stealthrock() },
			[32] = new List<Move>() { new Rockblast() },
			[38] = new List<Move>() { new Xscissor() },
			[44] = new List<Move>() { new Rockpolish() },
			[50] = new List<Move>() { new Shellsmash() },
			[56] = new List<Move>() { new Rockwrecker() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Bodypress(), new Bulldoze(), new Dig(), new Earthquake(), new Endure(), new Facade(), new Gigaimpact(), new Heavyslam(), new Hiddenpower(), new Hyperbeam(), new Irondefense(), new Meteorbeam(), new Poisonjab(), new Protect(), new Rest(), new Rockblast(), new Rockslide(), new Rocktomb(), new Round(), new Sandstorm(), new Sandtomb(), new Shadowclaw(), new Skittersmack(), new Sleeptalk(), new Snore(), new Solarbeam(), new Solarblade(), new Spikes(), new Stealthrock(), new Stompingtantrum(), new Stoneedge(), new Substitute(), new Swordsdance(), new Xscissor() };
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