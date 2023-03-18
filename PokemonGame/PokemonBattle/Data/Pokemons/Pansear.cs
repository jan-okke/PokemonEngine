using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Pansear : Pokemon
	{
		public override string Name => "Pansear";
		public override List<Ability> AvailableAbilities => new() {new Gluttony() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Blaze() };
		public override Stats BaseStats => new Stats(50, 53, 48, 64, 53, 48);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Fire };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Scratch(), new Playnice() },
			[4] = new List<Move>() { new Leer() },
			[7] = new List<Move>() { new Lick() },
			[10] = new List<Move>() { new Incinerate() },
			[13] = new List<Move>() { new Furyswipes() },
			[16] = new List<Move>() { new Yawn() },
			[19] = new List<Move>() { new Bite() },
			[22] = new List<Move>() { new Flameburst() },
			[25] = new List<Move>() { new Amnesia() },
			[28] = new List<Move>() { new Fling() },
			[31] = new List<Move>() { new Acrobatics() },
			[34] = new List<Move>() { new Fireblast() },
			[37] = new List<Move>() { new Recycle() },
			[40] = new List<Move>() { new Naturalgift() },
			[43] = new List<Move>() { new Crunch() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Acrobatics(), new Attract(), new Confide(), new Covet(), new Cut(), new Doubleteam(), new Endeavor(), new Facade(), new Fireblast(), new Firepledge(), new Firepunch(), new Flamecharge(), new Flamethrower(), new Fling(), new Focuspunch(), new Frustration(), new Gastroacid(), new Grassknot(), new Gunkshot(), new Heatwave(), new Helpinghand(), new Hiddenpower(), new Irontail(), new Knockoff(), new Lowkick(), new Lowsweep(), new Overheat(), new Payback(), new Protect(), new Recycle(), new Rest(), new Return(), new Rocksmash(), new Rocktomb(), new Roleplay(), new Round(), new Shadowclaw(), new Sleeptalk(), new Snore(), new Solarbeam(), new Substitute(), new Sunnyday(), new Swagger(), new Taunt(), new Thief(), new Torment(), new Toxic(), new Uproar(), new Willowisp(), new Workup() };
		public override List<Move> EggMoves => new List<Move>() { new Astonish(), new Belch(), new Covet(), new Disarmingvoice(), new Firepunch(), new Firespin(), new Flareblitz(), new Heatwave(), new Lowkick(), new Nastyplot(), new Roleplay(), new Sleeptalk(), new Tickle() };
		public override int Weight => 110;
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