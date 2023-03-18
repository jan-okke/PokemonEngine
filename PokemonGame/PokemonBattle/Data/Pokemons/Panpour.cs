using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Panpour : Pokemon
	{
		public override string Name => "Panpour";
		public override List<Ability> AvailableAbilities => new() {new Gluttony() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Torrent() };
		public override Stats BaseStats => new Stats(50, 53, 48, 53, 48, 64);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Water };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Scratch(), new Playnice() },
			[4] = new List<Move>() { new Leer() },
			[7] = new List<Move>() { new Lick() },
			[10] = new List<Move>() { new Watergun() },
			[13] = new List<Move>() { new Furyswipes() },
			[16] = new List<Move>() { new Watersport() },
			[19] = new List<Move>() { new Bite() },
			[22] = new List<Move>() { new Scald() },
			[25] = new List<Move>() { new Taunt() },
			[28] = new List<Move>() { new Fling() },
			[31] = new List<Move>() { new Acrobatics() },
			[34] = new List<Move>() { new Brine() },
			[37] = new List<Move>() { new Recycle() },
			[40] = new List<Move>() { new Naturalgift() },
			[43] = new List<Move>() { new Crunch() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Acrobatics(), new Aquatail(), new Attract(), new Blizzard(), new Confide(), new Covet(), new Cut(), new Dive(), new Doubleteam(), new Endeavor(), new Facade(), new Fling(), new Focuspunch(), new Frustration(), new Gastroacid(), new Grassknot(), new Gunkshot(), new Hail(), new Helpinghand(), new Hiddenpower(), new Icebeam(), new Icepunch(), new Icywind(), new Irontail(), new Knockoff(), new Lowkick(), new Lowsweep(), new Payback(), new Protect(), new Raindance(), new Recycle(), new Rest(), new Return(), new Rocksmash(), new Rocktomb(), new Roleplay(), new Round(), new Scald(), new Shadowclaw(), new Sleeptalk(), new Snore(), new Substitute(), new Surf(), new Swagger(), new Taunt(), new Thief(), new Torment(), new Toxic(), new Uproar(), new Waterfall(), new Waterpledge(), new Waterpulse(), new Workup() };
		public override List<Move> EggMoves => new List<Move>() { new Aquaring(), new Aquatail(), new Astonish(), new Covet(), new Disarmingvoice(), new Hydropump(), new Lowkick(), new Mudsport(), new Nastyplot(), new Roleplay(), new Tickle() };
		public override int Weight => 135;
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