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
		public override List<Ability> AvailableAbilities => new() {new Abilities.Gluttony() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Blaze() };
		public override Stats BaseStats => new Stats(50, 53, 48, 53, 48, 64);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Fire };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Moves.Scratch(), new Moves.Playnice() },
			[4] = new List<Move>() { new Moves.Leer() },
			[7] = new List<Move>() { new Moves.Lick() },
			[10] = new List<Move>() { new Moves.Incinerate() },
			[13] = new List<Move>() { new Moves.Furyswipes() },
			[16] = new List<Move>() { new Moves.Yawn() },
			[19] = new List<Move>() { new Moves.Bite() },
			[22] = new List<Move>() { new Moves.Flameburst() },
			[25] = new List<Move>() { new Moves.Amnesia() },
			[28] = new List<Move>() { new Moves.Fling() },
			[31] = new List<Move>() { new Moves.Acrobatics() },
			[34] = new List<Move>() { new Moves.Fireblast() },
			[37] = new List<Move>() { new Moves.Recycle() },
			[40] = new List<Move>() { new Moves.Naturalgift() },
			[43] = new List<Move>() { new Moves.Crunch() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Acrobatics(), new Moves.Attract(), new Moves.Confide(), new Moves.Covet(), new Moves.Cut(), new Moves.Doubleteam(), new Moves.Endeavor(), new Moves.Facade(), new Moves.Fireblast(), new Moves.Firepledge(), new Moves.Firepunch(), new Moves.Flamecharge(), new Moves.Flamethrower(), new Moves.Fling(), new Moves.Focuspunch(), new Moves.Frustration(), new Moves.Gastroacid(), new Moves.Grassknot(), new Moves.Gunkshot(), new Moves.Heatwave(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Irontail(), new Moves.Knockoff(), new Moves.Lowkick(), new Moves.Lowsweep(), new Moves.Overheat(), new Moves.Payback(), new Moves.Protect(), new Moves.Recycle(), new Moves.Rest(), new Moves.Return(), new Moves.Rocksmash(), new Moves.Rocktomb(), new Moves.Roleplay(), new Moves.Round(), new Moves.Shadowclaw(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Taunt(), new Moves.Thief(), new Moves.Torment(), new Moves.Toxic(), new Moves.Uproar(), new Moves.Willowisp(), new Moves.Workup() };
		public override List<Move> EggMoves => new List<Move>() { new Moves.Astonish(), new Moves.Belch(), new Moves.Covet(), new Moves.Disarmingvoice(), new Moves.Firepunch(), new Moves.Firespin(), new Moves.Flareblitz(), new Moves.Heatwave(), new Moves.Lowkick(), new Moves.Nastyplot(), new Moves.Roleplay(), new Moves.Sleeptalk(), new Moves.Tickle() };
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