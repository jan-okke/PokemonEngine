using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Simisage : Pokemon
{
	public override string Name => "Simisage";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Gluttony() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Overgrow() };
	public override Stats BaseStats => new Stats(75, 98, 63, 98, 63, 101);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
	public override List<PokemonType> Types => new() {PokemonType.Grass };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Leer(), new Moves.Lick(), new Moves.Furyswipes(), new Moves.Seedbomb() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Acrobatics(), new Moves.Attract(), new Moves.Brickbreak(), new Moves.Confide(), new Moves.Covet(), new Moves.Cut(), new Moves.Doubleteam(), new Moves.Endeavor(), new Moves.Energyball(), new Moves.Facade(), new Moves.Fling(), new Moves.Focusblast(), new Moves.Focuspunch(), new Moves.Frustration(), new Moves.Gastroacid(), new Moves.Gigadrain(), new Moves.Gigaimpact(), new Moves.Grassknot(), new Moves.Grasspledge(), new Moves.Gunkshot(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Irontail(), new Moves.Knockoff(), new Moves.Lowkick(), new Moves.Lowsweep(), new Moves.Naturepower(), new Moves.Payback(), new Moves.Poweruppunch(), new Moves.Protect(), new Moves.Recycle(), new Moves.Rest(), new Moves.Return(), new Moves.Rockslide(), new Moves.Rocksmash(), new Moves.Rocktomb(), new Moves.Roleplay(), new Moves.Round(), new Moves.Seedbomb(), new Moves.Shadowclaw(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Superpower(), new Moves.Swagger(), new Moves.Synthesis(), new Moves.Taunt(), new Moves.Thief(), new Moves.Throatchop(), new Moves.Torment(), new Moves.Toxic(), new Moves.Uproar(), new Moves.Workup(), new Moves.Worryseed() };
	public override int Weight => 305;
	public override int ExpYield => 174;
	public override int CatchRate => 75;
	public override Dictionary<Stat, int> EvYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 0,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 2
	};
}