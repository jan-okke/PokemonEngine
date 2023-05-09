using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Appletun : Pokemon
{
	public override string Name => "Appletun";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Ripen(), new Abilities.Gluttony() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Thickfat() };
	public override Stats BaseStats => new Stats(110, 85, 80, 100, 80, 30);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Erratic;
	public override List<PokemonType> Types => new() {PokemonType.Grass, PokemonType.Dragon };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[0] = new List<Move>() { new Moves.Headbutt() },
		[1] = new List<Move>() { new Moves.Headbutt(), new Moves.Recycle(), new Moves.Withdraw(), new Moves.Astonish(), new Moves.Growth(), new Moves.Sweetscent() },
		[4] = new List<Move>() { new Moves.Curse() },
		[8] = new List<Move>() { new Moves.Stomp() },
		[12] = new List<Move>() { new Moves.Leechseed() },
		[16] = new List<Move>() { new Moves.Protect() },
		[20] = new List<Move>() { new Moves.Bulletseed() },
		[24] = new List<Move>() { new Moves.Recover() },
		[28] = new List<Move>() { new Moves.Appleacid() },
		[32] = new List<Move>() { new Moves.Bodyslam() },
		[36] = new List<Move>() { new Moves.Irondefense() },
		[40] = new List<Move>() { new Moves.Dragonpulse() },
		[44] = new List<Move>() { new Moves.Energyball() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Amnesia(), new Moves.Attract(), new Moves.Bodypress(), new Moves.Bodyslam(), new Moves.Bulldoze(), new Moves.Bulletseed(), new Moves.Dracometeor(), new Moves.Dragonpulse(), new Moves.Earthquake(), new Moves.Endure(), new Moves.Energyball(), new Moves.Facade(), new Moves.Gigadrain(), new Moves.Gigaimpact(), new Moves.Grassknot(), new Moves.Grassyglide(), new Moves.Gyroball(), new Moves.Heavyslam(), new Moves.Hiddenpower(), new Moves.Highhorsepower(), new Moves.Hyperbeam(), new Moves.Irondefense(), new Moves.Lightscreen(), new Moves.Outrage(), new Moves.Payback(), new Moves.Protect(), new Moves.Reflect(), new Moves.Rest(), new Moves.Round(), new Moves.Safeguard(), new Moves.Seedbomb(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Superpower() };
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