using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Samurott : Pokemon
	{
		public override string Name => "Samurott";
		public override List<Ability> AvailableAbilities => new() {new Abilities.Torrent() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Shellarmor() };
		public override Stats BaseStats => new Stats(95, 100, 85, 108, 70, 70);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Water };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Moves.Slash() },
			[1] = new List<Move>() { new Moves.Slash(), new Moves.Megahorn(), new Moves.Tackle(), new Moves.Tailwhip(), new Moves.Watergun(), new Moves.Watersport() },
			[5] = new List<Move>() { new Moves.Tailwhip() },
			[7] = new List<Move>() { new Moves.Watergun() },
			[11] = new List<Move>() { new Moves.Watersport() },
			[13] = new List<Move>() { new Moves.Focusenergy() },
			[18] = new List<Move>() { new Moves.Razorshell() },
			[21] = new List<Move>() { new Moves.Furycutter() },
			[25] = new List<Move>() { new Moves.Waterpulse() },
			[29] = new List<Move>() { new Moves.Revenge() },
			[34] = new List<Move>() { new Moves.Aquajet() },
			[39] = new List<Move>() { new Moves.Encore() },
			[46] = new List<Move>() { new Moves.Aquatail() },
			[51] = new List<Move>() { new Moves.Retaliate() },
			[58] = new List<Move>() { new Moves.Swordsdance() },
			[63] = new List<Move>() { new Moves.Hydropump() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Aerialace(), new Moves.Aquatail(), new Moves.Attract(), new Moves.Blizzard(), new Moves.Block(), new Moves.Confide(), new Moves.Covet(), new Moves.Cut(), new Moves.Dive(), new Moves.Doubleteam(), new Moves.Dragontail(), new Moves.Facade(), new Moves.Falseswipe(), new Moves.Fling(), new Moves.Frustration(), new Moves.Gigaimpact(), new Moves.Grassknot(), new Moves.Hail(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Hydrocannon(), new Moves.Hyperbeam(), new Moves.Icebeam(), new Moves.Icywind(), new Moves.Irontail(), new Moves.Knockoff(), new Moves.Liquidation(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Return(), new Moves.Rocksmash(), new Moves.Round(), new Moves.Scald(), new Moves.Sleeptalk(), new Moves.Smartstrike(), new Moves.Snore(), new Moves.Strength(), new Moves.Substitute(), new Moves.Superpower(), new Moves.Surf(), new Moves.Swagger(), new Moves.Swordsdance(), new Moves.Taunt(), new Moves.Toxic(), new Moves.Waterfall(), new Moves.Waterpledge(), new Moves.Waterpulse(), new Moves.Workup(), new Moves.Xscissor() };
		public override int Weight => 946;
		public override int ExpYield => 264;
		public override int CatchRate => 45;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 3,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}