using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Vanilluxe : Pokemon
{
	public override string Name => "Vanilluxe";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Icebody(), new Abilities.Snowwarning() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Weakarmor() };
	public override Stats BaseStats => new Stats(71, 95, 85, 110, 95, 79);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
	public override List<PokemonType> Types => new() {PokemonType.Ice };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Weatherball(), new Moves.Iciclecrash(), new Moves.Freezedry(), new Moves.Astonish(), new Moves.Harden(), new Moves.Taunt(), new Moves.Mist() },
		[12] = new List<Move>() { new Moves.Icywind() },
		[16] = new List<Move>() { new Moves.Avalanche() },
		[20] = new List<Move>() { new Moves.Hail() },
		[24] = new List<Move>() { new Moves.Iciclespear() },
		[28] = new List<Move>() { new Moves.Uproar() },
		[32] = new List<Move>() { new Moves.Acidarmor() },
		[38] = new List<Move>() { new Moves.Mirrorcoat() },
		[44] = new List<Move>() { new Moves.Icebeam() },
		[52] = new List<Move>() { new Moves.Blizzard() },
		[60] = new List<Move>() { new Moves.Sheercold() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Allyswitch(), new Moves.Attract(), new Moves.Avalanche(), new Moves.Beatup(), new Moves.Blizzard(), new Moves.Endure(), new Moves.Facade(), new Moves.Flashcannon(), new Moves.Gigaimpact(), new Moves.Hail(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Hypervoice(), new Moves.Icebeam(), new Moves.Iciclespear(), new Moves.Icywind(), new Moves.Imprison(), new Moves.Irondefense(), new Moves.Lightscreen(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Round(), new Moves.Selfdestruct(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Substitute(), new Moves.Taunt(), new Moves.Uproar(), new Moves.Weatherball() };
	public override int Weight => 575;
	public override int ExpYield => 268;
	public override int CatchRate => 45;
	public override Dictionary<Stat, int> EvYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 0,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 3,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}