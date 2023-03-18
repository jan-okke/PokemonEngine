using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Sirfetchd : Pokemon
	{
		public override string Name => "Sirfetch'd";
		public override List<Ability> AvailableAbilities => new() {new Abilities.Steadfast() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Scrappy() };
		public override Stats BaseStats => new Stats(62, 135, 95, 68, 82, 65);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Fighting };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Moves.Irondefense() },
			[1] = new List<Move>() { new Moves.Irondefense(), new Moves.Firstimpression(), new Moves.Peck(), new Moves.Sandattack(), new Moves.Leer(), new Moves.Furycutter() },
			[15] = new List<Move>() { new Moves.Rocksmash() },
			[20] = new List<Move>() { new Moves.Brutalswing() },
			[25] = new List<Move>() { new Moves.Detect() },
			[30] = new List<Move>() { new Moves.Knockoff() },
			[35] = new List<Move>() { new Moves.Defog() },
			[40] = new List<Move>() { new Moves.Brickbreak() },
			[45] = new List<Move>() { new Moves.Swordsdance() },
			[50] = new List<Move>() { new Moves.Slam() },
			[55] = new List<Move>() { new Moves.Leafblade() },
			[60] = new List<Move>() { new Moves.Finalgambit() },
			[65] = new List<Move>() { new Moves.Bravebird() },
			[70] = new List<Move>() { new Moves.Meteorassault() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Assurance(), new Moves.Attract(), new Moves.Bodyslam(), new Moves.Bravebird(), new Moves.Brickbreak(), new Moves.Brutalswing(), new Moves.Closecombat(), new Moves.Coaching(), new Moves.Dualwingbeat(), new Moves.Endure(), new Moves.Facade(), new Moves.Focusenergy(), new Moves.Grassyglide(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Irondefense(), new Moves.Leafblade(), new Moves.Poisonjab(), new Moves.Protect(), new Moves.Rest(), new Moves.Retaliate(), new Moves.Revenge(), new Moves.Round(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Solarblade(), new Moves.Steelwing(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Superpower(), new Moves.Swordsdance(), new Moves.Throatchop(), new Moves.Workup() };
		public override List<Move> EggMoves => new List<Move>() { new Moves.Counter(), new Moves.Covet(), new Moves.Curse(), new Moves.Doubleedge(), new Moves.Feint(), new Moves.Flail(), new Moves.Nightslash(), new Moves.Quickattack(), new Moves.Quickguard(), new Moves.Simplebeam(), new Moves.Skyattack() };
		public override int Weight => 1170;
		public override int ExpYield => 177;
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