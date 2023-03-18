using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Dewott : Pokemon
	{
		public override string Name => "Dewott";
		public override List<Ability> AvailableAbilities => new() {new Torrent() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Shellarmor() };
		public override Stats BaseStats => new Stats(75, 75, 60, 83, 60, 60);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Water };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Tackle(), new Tailwhip(), new Watergun(), new Watersport() },
			[5] = new List<Move>() { new Tailwhip() },
			[7] = new List<Move>() { new Watergun() },
			[11] = new List<Move>() { new Watersport() },
			[13] = new List<Move>() { new Focusenergy() },
			[18] = new List<Move>() { new Razorshell() },
			[21] = new List<Move>() { new Furycutter() },
			[26] = new List<Move>() { new Waterpulse() },
			[29] = new List<Move>() { new Revenge() },
			[34] = new List<Move>() { new Aquajet() },
			[37] = new List<Move>() { new Encore() },
			[42] = new List<Move>() { new Aquatail() },
			[45] = new List<Move>() { new Retaliate() },
			[50] = new List<Move>() { new Swordsdance() },
			[53] = new List<Move>() { new Hydropump() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Aerialace(), new Aquatail(), new Attract(), new Blizzard(), new Confide(), new Covet(), new Cut(), new Dive(), new Doubleteam(), new Facade(), new Falseswipe(), new Fling(), new Frustration(), new Grassknot(), new Hail(), new Helpinghand(), new Hiddenpower(), new Icebeam(), new Icywind(), new Irontail(), new Protect(), new Raindance(), new Rest(), new Return(), new Rocksmash(), new Round(), new Scald(), new Sleeptalk(), new Snore(), new Substitute(), new Surf(), new Swagger(), new Swordsdance(), new Taunt(), new Toxic(), new Waterfall(), new Waterpledge(), new Waterpulse(), new Workup(), new Xscissor() };
		public override int Weight => 245;
		public override int ExpYield => 145;
		public override int CatchRate => 45;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 2,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}