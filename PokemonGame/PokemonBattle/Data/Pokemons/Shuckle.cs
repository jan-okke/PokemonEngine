using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Shuckle : Pokemon
	{
		public override string Name => "Shuckle";
		public override List<Ability> AvailableAbilities => new() {new Sturdy(), new Gluttony() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Contrary() };
		public override Stats BaseStats => new Stats(20, 10, 230, 5, 10, 230);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Bug, PokemonType.Rock };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Withdraw(), new Wrap() },
			[5] = new List<Move>() { new Rollout() },
			[10] = new List<Move>() { new Strugglebug() },
			[15] = new List<Move>() { new Rockthrow() },
			[20] = new List<Move>() { new Safeguard() },
			[25] = new List<Move>() { new Rest() },
			[30] = new List<Move>() { new Bugbite() },
			[35] = new List<Move>() { new Powersplit(), new Guardsplit() },
			[40] = new List<Move>() { new Rockslide() },
			[45] = new List<Move>() { new Gastroacid() },
			[50] = new List<Move>() { new Stickyweb() },
			[55] = new List<Move>() { new Powertrick() },
			[60] = new List<Move>() { new Stoneedge() },
			[65] = new List<Move>() { new Shellsmash() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Bodyslam(), new Bulldoze(), new Dig(), new Doubleteam(), new Earthpower(), new Earthquake(), new Encore(), new Endure(), new Facade(), new Flash(), new Gyroball(), new Helpinghand(), new Hiddenpower(), new Irondefense(), new Meteorbeam(), new Mudshot(), new Protect(), new Rest(), new Reversal(), new Rockblast(), new Rockpolish(), new Rockslide(), new Rocksmash(), new Rocktomb(), new Round(), new Safeguard(), new Sandstorm(), new Sandtomb(), new Skittersmack(), new Sleeptalk(), new Sludgebomb(), new Sludgewave(), new Snore(), new Stealthrock(), new Steelroller(), new Stoneedge(), new Strength(), new Substitute(), new Sunnyday(), new Swagger(), new Toxic(), new Venoshock() };
		public override List<Move> EggMoves => new List<Move>() { new Acid(), new Acupressure(), new Covet(), new Defensecurl(), new Finalgambit(), new Helpinghand(), new Infestation(), new Knockoff(), new Mudslap(), new Rockblast(), new Sandtomb(), new Sweetscent() };
		public override int Weight => 205;
		public override int ExpYield => 177;
		public override int CatchRate => 190;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 1,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 1,
			[Stat.Speed] = 0
		};
	}
}