using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Vespiquen : Pokemon
{
	public override string Name => "Vespiquen";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Pressure() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Unnerve() };
	public override Stats BaseStats => new Stats(70, 80, 102, 80, 102, 40);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
	public override List<PokemonType> Types => new() {PokemonType.Bug, PokemonType.Flying };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[0] = new List<Move>() { new Moves.Slash() },
		[1] = new List<Move>() { new Moves.Slash(), new Moves.Strugglebug(), new Moves.Bugbite(), new Moves.Sweetscent(), new Moves.Gust(), new Moves.Poisonsting(), new Moves.Confuseray() },
		[4] = new List<Move>() { new Moves.Furycutter() },
		[8] = new List<Move>() { new Moves.Aromaticmist() },
		[12] = new List<Move>() { new Moves.Fellstinger() },
		[16] = new List<Move>() { new Moves.Furyswipes() },
		[20] = new List<Move>() { new Moves.Swagger() },
		[24] = new List<Move>() { new Moves.Aromatherapy() },
		[28] = new List<Move>() { new Moves.Airslash() },
		[32] = new List<Move>() { new Moves.Powergem() },
		[36] = new List<Move>() { new Moves.Toxic() },
		[40] = new List<Move>() { new Moves.Attackorder(), new Moves.Defendorder() },
		[44] = new List<Move>() { new Moves.Destinybond() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Acrobatics(), new Moves.Aerialace(), new Moves.Airslash(), new Moves.Assurance(), new Moves.Attract(), new Moves.Beatup(), new Moves.Bugbuzz(), new Moves.Crosspoison(), new Moves.Cut(), new Moves.Defog(), new Moves.Doubleteam(), new Moves.Dualwingbeat(), new Moves.Endure(), new Moves.Facade(), new Moves.Flash(), new Moves.Fling(), new Moves.Gigaimpact(), new Moves.Hex(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Pinmissile(), new Moves.Powergem(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Revenge(), new Moves.Reversal(), new Moves.Roost(), new Moves.Round(), new Moves.Screech(), new Moves.Sleeptalk(), new Moves.Sludgebomb(), new Moves.Snore(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Swift(), new Moves.Thief(), new Moves.Toxic(), new Moves.Toxicspikes(), new Moves.Uproar(), new Moves.Uturn(), new Moves.Venoshock(), new Moves.Xscissor() };
	public override int Weight => 385;
	public override int ExpYield => 166;
	public override int CatchRate => 45;
	public override Dictionary<Stat, int> EvYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 0,
		[Stat.Defense] = 1,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 1,
		[Stat.Speed] = 0
	};
}