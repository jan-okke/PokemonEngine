using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Shellder : Pokemon
	{
		public override string Name => "Shellder";
		public override List<Ability> AvailableAbilities => new() {new Shellarmor(), new Skilllink() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Overcoat() };
		public override Stats BaseStats => new Stats(30, 65, 100, 45, 25, 40);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Water };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Tackle(), new Watergun() },
			[4] = new List<Move>() { new Withdraw() },
			[8] = new List<Move>() { new Iceshard() },
			[12] = new List<Move>() { new Leer() },
			[16] = new List<Move>() { new Whirlpool() },
			[20] = new List<Move>() { new Supersonic() },
			[24] = new List<Move>() { new Aurorabeam() },
			[28] = new List<Move>() { new Protect() },
			[32] = new List<Move>() { new Razorshell() },
			[36] = new List<Move>() { new Irondefense() },
			[40] = new List<Move>() { new Icebeam() },
			[44] = new List<Move>() { new Shellsmash() },
			[48] = new List<Move>() { new Hydropump() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Avalanche(), new Blizzard(), new Brine(), new Dive(), new Doubleteam(), new Endure(), new Explosion(), new Facade(), new Hail(), new Hiddenpower(), new Hydropump(), new Icebeam(), new Iciclespear(), new Icywind(), new Irondefense(), new Liquidation(), new Mudshot(), new Payback(), new Protect(), new Raindance(), new Razorshell(), new Rest(), new Rockblast(), new Round(), new Screech(), new Selfdestruct(), new Sleeptalk(), new Snore(), new Substitute(), new Surf(), new Swagger(), new Swift(), new Triattack(), new Waterpulse(), new Whirlpool() };
		public override List<Move> EggMoves => new List<Move>() { new Aquaring(), new Bubblebeam(), new Iciclespear(), new Lifedew(), new Mudshot(), new Rapidspin(), new Rockblast(), new Screech(), new Takedown() };
		public override int Weight => 40;
		public override int ExpYield => 61;
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