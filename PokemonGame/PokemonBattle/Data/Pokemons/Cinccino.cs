using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Cinccino : Pokemon
{
	public override string Name => "Cinccino";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Cutecharm(), new Abilities.Technician() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Skilllink() };
	public override Stats BaseStats => new Stats(75, 95, 60, 65, 60, 115);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Fast;
	public override List<PokemonType> Types => new() {PokemonType.Normal };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Bulletseed(), new Moves.Rockblast(), new Moves.Sing(), new Moves.Charm(), new Moves.Swift(), new Moves.Encore(), new Moves.Afteryou(), new Moves.Tailslap(), new Moves.Tickle(), new Moves.Slam(), new Moves.Hypervoice(), new Moves.Lastresort(), new Moves.Pound(), new Moves.Babydolleyes(), new Moves.Helpinghand(), new Moves.Echoedvoice() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Attract(), new Moves.Bulletseed(), new Moves.Calmmind(), new Moves.Charm(), new Moves.Dazzlinggleam(), new Moves.Dig(), new Moves.Encore(), new Moves.Endure(), new Moves.Facade(), new Moves.Faketears(), new Moves.Fling(), new Moves.Focusblast(), new Moves.Gigaimpact(), new Moves.Grassknot(), new Moves.Gunkshot(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Hypervoice(), new Moves.Irontail(), new Moves.Lightscreen(), new Moves.Playrough(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Retaliate(), new Moves.Rockblast(), new Moves.Round(), new Moves.Safeguard(), new Moves.Seedbomb(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swift(), new Moves.Tailslap(), new Moves.Thief(), new Moves.Thunder(), new Moves.Thunderbolt(), new Moves.Thunderwave(), new Moves.Tripleaxel(), new Moves.Uproar(), new Moves.Uturn(), new Moves.Workup() };
	public override int Weight => 75;
	public override int ExpYield => 165;
	public override int CatchRate => 60;
	public override Dictionary<Stat, int> EVYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 0,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 2
	};
}