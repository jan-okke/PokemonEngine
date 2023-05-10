using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Silvally : Pokemon
{
	public override string Name => "Silvally";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Rkssystem() };
	public override Stats BaseStats => new Stats(95, 95, 95, 95, 95, 95);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
	public override List<PokemonType> Types => new() {PokemonType.Normal };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[0] = new List<Move>() { new Moves.Multiattack() },
		[1] = new List<Move>() { new Moves.Multiattack(), new Moves.Explosion(), new Moves.Thunderfang(), new Moves.Icefang(), new Moves.Firefang(), new Moves.Poisonfang(), new Moves.Imprison(), new Moves.Ironhead(), new Moves.Tackle(), new Moves.Bite(), new Moves.Aerialace(), new Moves.Scaryface() },
		[15] = new List<Move>() { new Moves.Doublehit() },
		[20] = new List<Move>() { new Moves.Metalsound() },
		[25] = new List<Move>() { new Moves.Crushclaw() },
		[30] = new List<Move>() { new Moves.Airslash() },
		[35] = new List<Move>() { new Moves.Triattack() },
		[40] = new List<Move>() { new Moves.Xscissor() },
		[45] = new List<Move>() { new Moves.Crunch() },
		[50] = new List<Move>() { new Moves.Takedown() },
		[55] = new List<Move>() { new Moves.Doubleedge() },
		[60] = new List<Move>() { new Moves.Partingshot() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Airslash(), new Moves.Crunch(), new Moves.Dracometeor(), new Moves.Dragonclaw(), new Moves.Endure(), new Moves.Facade(), new Moves.Firefang(), new Moves.Flamethrower(), new Moves.Flashcannon(), new Moves.Gigaimpact(), new Moves.Grasspledge(), new Moves.Hail(), new Moves.Heatwave(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Hypervoice(), new Moves.Icebeam(), new Moves.Icefang(), new Moves.Icywind(), new Moves.Imprison(), new Moves.Irondefense(), new Moves.Ironhead(), new Moves.Outrage(), new Moves.Payback(), new Moves.Protect(), new Moves.Psychicfangs(), new Moves.Raindance(), new Moves.Rest(), new Moves.Reversal(), new Moves.Rockslide(), new Moves.Round(), new Moves.Sandstorm(), new Moves.Scaryface(), new Moves.Selfdestruct(), new Moves.Shadowball(), new Moves.Shadowclaw(), new Moves.Sleeptalk(), new Moves.Snarl(), new Moves.Snore(), new Moves.Steelbeam(), new Moves.Steelwing(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Surf(), new Moves.Swift(), new Moves.Swordsdance(), new Moves.Terrainpulse(), new Moves.Thunderbolt(), new Moves.Thunderfang(), new Moves.Thunderwave(), new Moves.Triattack(), new Moves.Uturn(), new Moves.Workup(), new Moves.Xscissor(), new Moves.Zenheadbutt() };
	public override int Weight => 1005;
	public override int ExpYield => 285;
	public override int CatchRate => 3;
	public override Dictionary<Stat, int> EvYield => new()
	{
		[Stat.HP] = 3,
		[Stat.Attack] = 0,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}