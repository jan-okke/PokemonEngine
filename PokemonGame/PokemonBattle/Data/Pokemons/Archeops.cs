using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Archeops : Pokemon
{
	public override string Name => "Archeops";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Defeatist() };
	public override Stats BaseStats => new Stats(75, 140, 65, 112, 65, 110);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
	public override List<PokemonType> Types => new() {PokemonType.Rock, PokemonType.Flying };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Quickattack(), new Moves.Leer(), new Moves.Rockthrow(), new Moves.Wingattack() },
		[9] = new List<Move>() { new Moves.Dragonbreath() },
		[12] = new List<Move>() { new Moves.Ancientpower() },
		[15] = new List<Move>() { new Moves.Pluck() },
		[18] = new List<Move>() { new Moves.Quickguard() },
		[21] = new List<Move>() { new Moves.Uturn() },
		[24] = new List<Move>() { new Moves.Rockslide() },
		[27] = new List<Move>() { new Moves.Scaryface() },
		[30] = new List<Move>() { new Moves.Crunch() },
		[33] = new List<Move>() { new Moves.Agility() },
		[36] = new List<Move>() { new Moves.Tailwind() },
		[41] = new List<Move>() { new Moves.Dragonclaw() },
		[46] = new List<Move>() { new Moves.Thrash() },
		[51] = new List<Move>() { new Moves.Endeavor() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Acrobatics(), new Moves.Agility(), new Moves.Airslash(), new Moves.Allyswitch(), new Moves.Assurance(), new Moves.Attract(), new Moves.Bounce(), new Moves.Bulldoze(), new Moves.Crunch(), new Moves.Dig(), new Moves.Dragonclaw(), new Moves.Dragonpulse(), new Moves.Dualwingbeat(), new Moves.Earthpower(), new Moves.Earthquake(), new Moves.Endure(), new Moves.Facade(), new Moves.Fly(), new Moves.Focusblast(), new Moves.Gigaimpact(), new Moves.Heatwave(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Irondefense(), new Moves.Irontail(), new Moves.Lashout(), new Moves.Meteorbeam(), new Moves.Outrage(), new Moves.Protect(), new Moves.Rest(), new Moves.Rockblast(), new Moves.Rockslide(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Sandstorm(), new Moves.Scaryface(), new Moves.Shadowclaw(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Stealthrock(), new Moves.Steelwing(), new Moves.Stoneedge(), new Moves.Substitute(), new Moves.Swift(), new Moves.Taunt(), new Moves.Uproar(), new Moves.Uturn(), new Moves.Zenheadbutt() };
	public override int Weight => 320;
	public override int ExpYield => 177;
	public override int CatchRate => 45;
	public override Dictionary<Stat, int> EvYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 2,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}