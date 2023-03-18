using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Appletun : Pokemon
	{
		public override string Name => "Appletun";
		public override List<Ability> AvailableAbilities => new() {new Ripen(), new Gluttony() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Thickfat() };
		public override Stats BaseStats => new Stats(110, 85, 80, 30, 100, 80);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Erratic;
		public override List<PokemonType> Types => new() {PokemonType.Grass, PokemonType.Dragon };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Headbutt() },
			[1] = new List<Move>() { new Headbutt(), new Recycle(), new Withdraw(), new Astonish(), new Growth(), new Sweetscent() },
			[4] = new List<Move>() { new Curse() },
			[8] = new List<Move>() { new Stomp() },
			[12] = new List<Move>() { new Leechseed() },
			[16] = new List<Move>() { new Protect() },
			[20] = new List<Move>() { new Bulletseed() },
			[24] = new List<Move>() { new Recover() },
			[28] = new List<Move>() { new Appleacid() },
			[32] = new List<Move>() { new Bodyslam() },
			[36] = new List<Move>() { new Irondefense() },
			[40] = new List<Move>() { new Dragonpulse() },
			[44] = new List<Move>() { new Energyball() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Amnesia(), new Attract(), new Bodypress(), new Bodyslam(), new Bulldoze(), new Bulletseed(), new Dracometeor(), new Dragonpulse(), new Earthquake(), new Endure(), new Energyball(), new Facade(), new Gigadrain(), new Gigaimpact(), new Grassknot(), new Grassyglide(), new Gyroball(), new Heavyslam(), new Hiddenpower(), new Highhorsepower(), new Hyperbeam(), new Irondefense(), new Lightscreen(), new Outrage(), new Payback(), new Protect(), new Reflect(), new Rest(), new Round(), new Safeguard(), new Seedbomb(), new Sleeptalk(), new Snore(), new Solarbeam(), new Substitute(), new Sunnyday(), new Superpower() };
		public override int Weight => 130;
		public override int ExpYield => 170;
		public override int CatchRate => 45;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 2,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}