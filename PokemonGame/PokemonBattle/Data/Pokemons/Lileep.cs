using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Lileep : Pokemon
	{
		public override string Name => "Lileep";
		public override List<Ability> AvailableAbilities => new() {new Suctioncups() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Stormdrain() };
		public override Stats BaseStats => new Stats(66, 41, 77, 61, 87, 23);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Erratic;
		public override List<PokemonType> Types => new() {PokemonType.Rock, PokemonType.Grass };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Wrap(), new Astonish() },
			[4] = new List<Move>() { new Acid() },
			[8] = new List<Move>() { new Confuseray() },
			[12] = new List<Move>() { new Ingrain() },
			[16] = new List<Move>() { new Ancientpower() },
			[20] = new List<Move>() { new Megadrain() },
			[24] = new List<Move>() { new Brine() },
			[28] = new List<Move>() { new Amnesia() },
			[32] = new List<Move>() { new Gastroacid() },
			[36] = new List<Move>() { new Gigadrain() },
			[41] = new List<Move>() { new Stockpile(), new Spitup(), new Swallow() },
			[44] = new List<Move>() { new Energyball() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Amnesia(), new Attract(), new Bodyslam(), new Brine(), new Bulletseed(), new Doubleteam(), new Earthpower(), new Endure(), new Energyball(), new Facade(), new Flash(), new Gigadrain(), new Grassknot(), new Hiddenpower(), new Meteorbeam(), new Mudshot(), new Protect(), new Rest(), new Rockblast(), new Rockpolish(), new Rockslide(), new Rocktomb(), new Round(), new Sandstorm(), new Seedbomb(), new Sleeptalk(), new Sludgebomb(), new Snore(), new Solarbeam(), new Stealthrock(), new Substitute(), new Sunnyday(), new Swagger(), new Swordsdance() };
		public override List<Move> EggMoves => new List<Move>() { new Bind(), new Curse(), new Megadrain(), new Mirrorcoat(), new Recover(), new Tickle() };
		public override int Weight => 238;
		public override int ExpYield => 71;
		public override int CatchRate => 45;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 1,
			[Stat.Speed] = 0
		};
	}
}