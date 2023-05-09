using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Butterfree : Pokemon
{
	public override string Name => "Butterfree";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Compoundeyes() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Tintedlens() };
	public override Stats BaseStats => new Stats(60, 45, 50, 90, 80, 70);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
	public override List<PokemonType> Types => new() {PokemonType.Bug, PokemonType.Flying };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[0] = new List<Move>() { new Moves.Gust() },
		[1] = new List<Move>() { new Moves.Gust(), new Moves.Harden(), new Moves.Tackle(), new Moves.Stringshot(), new Moves.Bugbite() },
		[4] = new List<Move>() { new Moves.Supersonic() },
		[8] = new List<Move>() { new Moves.Confusion() },
		[12] = new List<Move>() { new Moves.Poisonpowder(), new Moves.Stunspore(), new Moves.Sleeppowder() },
		[16] = new List<Move>() { new Moves.Psybeam() },
		[20] = new List<Move>() { new Moves.Whirlwind() },
		[24] = new List<Move>() { new Moves.Airslash() },
		[28] = new List<Move>() { new Moves.Safeguard() },
		[32] = new List<Move>() { new Moves.Bugbuzz() },
		[36] = new List<Move>() { new Moves.Tailwind() },
		[40] = new List<Move>() { new Moves.Ragepowder() },
		[44] = new List<Move>() { new Moves.Quiverdance() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Acrobatics(), new Moves.Aerialace(), new Moves.Airslash(), new Moves.Attract(), new Moves.Batonpass(), new Moves.Bugbuzz(), new Moves.Defog(), new Moves.Doubleteam(), new Moves.Drainingkiss(), new Moves.Dreameater(), new Moves.Dualwingbeat(), new Moves.Electroweb(), new Moves.Endure(), new Moves.Energyball(), new Moves.Facade(), new Moves.Flash(), new Moves.Gigadrain(), new Moves.Gigaimpact(), new Moves.Hiddenpower(), new Moves.Hurricane(), new Moves.Hyperbeam(), new Moves.Irondefense(), new Moves.Pollenpuff(), new Moves.Protect(), new Moves.Psychic(), new Moves.Psychup(), new Moves.Raindance(), new Moves.Rest(), new Moves.Roost(), new Moves.Round(), new Moves.Safeguard(), new Moves.Shadowball(), new Moves.Skillswap(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Swift(), new Moves.Thief(), new Moves.Uturn(), new Moves.Venoshock() };
	public override int Weight => 320;
	public override int ExpYield => 198;
	public override int CatchRate => 45;
	public override Dictionary<Stat, int> EVYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 0,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 2,
		[Stat.SpecialDefense] = 1,
		[Stat.Speed] = 0
	};
}