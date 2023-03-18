using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Pansage : Pokemon
	{
		public override string Name => "Pansage";
		public override List<Ability> AvailableAbilities => new() {new Gluttony() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Overgrow() };
		public override Stats BaseStats => new Stats(50, 53, 48, 53, 48, 64);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Grass };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Scratch(), new Playnice() },
			[4] = new List<Move>() { new Leer() },
			[7] = new List<Move>() { new Lick() },
			[10] = new List<Move>() { new Vinewhip() },
			[13] = new List<Move>() { new Furyswipes() },
			[16] = new List<Move>() { new Leechseed() },
			[19] = new List<Move>() { new Bite() },
			[22] = new List<Move>() { new Seedbomb() },
			[25] = new List<Move>() { new Torment() },
			[28] = new List<Move>() { new Fling() },
			[31] = new List<Move>() { new Acrobatics() },
			[34] = new List<Move>() { new Grassknot() },
			[37] = new List<Move>() { new Recycle() },
			[40] = new List<Move>() { new Naturalgift() },
			[43] = new List<Move>() { new Crunch() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Acrobatics(), new Attract(), new Confide(), new Covet(), new Cut(), new Doubleteam(), new Endeavor(), new Energyball(), new Facade(), new Fling(), new Focuspunch(), new Frustration(), new Gastroacid(), new Gigadrain(), new Grassknot(), new Grasspledge(), new Gunkshot(), new Helpinghand(), new Hiddenpower(), new Irontail(), new Knockoff(), new Lowkick(), new Lowsweep(), new Naturepower(), new Payback(), new Protect(), new Recycle(), new Rest(), new Return(), new Rocksmash(), new Rocktomb(), new Roleplay(), new Round(), new Seedbomb(), new Shadowclaw(), new Sleeptalk(), new Snore(), new Solarbeam(), new Substitute(), new Sunnyday(), new Swagger(), new Synthesis(), new Taunt(), new Thief(), new Torment(), new Toxic(), new Uproar(), new Workup(), new Worryseed() };
		public override List<Move> EggMoves => new List<Move>() { new Astonish(), new Bulletseed(), new Covet(), new Disarmingvoice(), new Grasswhistle(), new Leafstorm(), new Lowkick(), new Magicalleaf(), new Nastyplot(), new Roleplay(), new Spikyshield(), new Tickle() };
		public override int Weight => 105;
		public override int ExpYield => 63;
		public override int CatchRate => 190;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 1
		};
	}
}