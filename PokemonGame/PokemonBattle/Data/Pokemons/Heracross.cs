using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Heracross : Pokemon
	{
		public override string Name => "Heracross";
		public override List<Ability> AvailableAbilities => new() {new Abilities.Swarm(), new Abilities.Guts() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Moxie() };
		public override Stats BaseStats => new Stats(80, 125, 75, 40, 95, 85);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Bug, PokemonType.Fighting };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Moves.Tackle(), new Moves.Leer() },
			[5] = new List<Move>() { new Moves.Furyattack() },
			[10] = new List<Move>() { new Moves.Endure() },
			[15] = new List<Move>() { new Moves.Aerialace() },
			[20] = new List<Move>() { new Moves.Hornattack() },
			[25] = new List<Move>() { new Moves.Counter() },
			[30] = new List<Move>() { new Moves.Brickbreak() },
			[35] = new List<Move>() { new Moves.Pinmissile() },
			[40] = new List<Move>() { new Moves.Throatchop() },
			[45] = new List<Move>() { new Moves.Thrash() },
			[50] = new List<Move>() { new Moves.Swordsdance() },
			[55] = new List<Move>() { new Moves.Megahorn() },
			[60] = new List<Move>() { new Moves.Closecombat() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Aerialace(), new Moves.Assurance(), new Moves.Attract(), new Moves.Bodyslam(), new Moves.Brickbreak(), new Moves.Brutalswing(), new Moves.Bulkup(), new Moves.Bulldoze(), new Moves.Bulletseed(), new Moves.Closecombat(), new Moves.Coaching(), new Moves.Cut(), new Moves.Dig(), new Moves.Doubleteam(), new Moves.Earthquake(), new Moves.Endure(), new Moves.Facade(), new Moves.Falseswipe(), new Moves.Fling(), new Moves.Focusblast(), new Moves.Focuspunch(), new Moves.Gigaimpact(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Highhorsepower(), new Moves.Hyperbeam(), new Moves.Irondefense(), new Moves.Lowkick(), new Moves.Megahorn(), new Moves.Pinmissile(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Retaliate(), new Moves.Revenge(), new Moves.Reversal(), new Moves.Rockblast(), new Moves.Rockslide(), new Moves.Rocksmash(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Shadowclaw(), new Moves.Sleeptalk(), new Moves.Smartstrike(), new Moves.Snore(), new Moves.Spikes(), new Moves.Stoneedge(), new Moves.Strength(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Swordsdance(), new Moves.Thief(), new Moves.Throatchop(), new Moves.Venoshock(), new Moves.Workup() };
		public override List<Move> EggMoves => new List<Move>() { new Moves.Doubleedge(), new Moves.Feint(), new Moves.Flail(), new Moves.Harden(), new Moves.Megahorn(), new Moves.Nightslash(), new Moves.Revenge(), new Moves.Rockblast(), new Moves.Seismictoss(), new Moves.Takedown() };
		public override int Weight => 540;
		public override int ExpYield => 175;
		public override int CatchRate => 45;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 2,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}