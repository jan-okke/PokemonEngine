using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Oranguru : Pokemon
{
	public override string Name => "Oranguru";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Innerfocus(), new Abilities.Telepathy() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Symbiosis() };
	public override Stats BaseStats => new Stats(90, 60, 80, 90, 110, 60);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
	public override List<PokemonType> Types => new() {PokemonType.Normal, PokemonType.Psychic };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Confusion(), new Moves.Taunt() },
		[5] = new List<Move>() { new Moves.Afteryou() },
		[10] = new List<Move>() { new Moves.Calmmind() },
		[15] = new List<Move>() { new Moves.Storedpower() },
		[20] = new List<Move>() { new Moves.Psychup() },
		[25] = new List<Move>() { new Moves.Quash() },
		[30] = new List<Move>() { new Moves.Nastyplot() },
		[35] = new List<Move>() { new Moves.Zenheadbutt() },
		[40] = new List<Move>() { new Moves.Trickroom() },
		[45] = new List<Move>() { new Moves.Psychic() },
		[50] = new List<Move>() { new Moves.Instruct() },
		[55] = new List<Move>() { new Moves.Foulplay() },
		[60] = new List<Move>() { new Moves.Futuresight() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Allyswitch(), new Moves.Attract(), new Moves.Brickbreak(), new Moves.Brutalswing(), new Moves.Bulldoze(), new Moves.Calmmind(), new Moves.Earthquake(), new Moves.Encore(), new Moves.Endure(), new Moves.Energyball(), new Moves.Expandingforce(), new Moves.Facade(), new Moves.Fling(), new Moves.Focusblast(), new Moves.Foulplay(), new Moves.Futuresight(), new Moves.Gigaimpact(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Imprison(), new Moves.Lightscreen(), new Moves.Magicroom(), new Moves.Megakick(), new Moves.Megapunch(), new Moves.Nastyplot(), new Moves.Payback(), new Moves.Protect(), new Moves.Psychic(), new Moves.Psychicterrain(), new Moves.Psyshock(), new Moves.Raindance(), new Moves.Reflect(), new Moves.Rest(), new Moves.Rockslide(), new Moves.Round(), new Moves.Safeguard(), new Moves.Shadowball(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Storedpower(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Taunt(), new Moves.Terrainpulse(), new Moves.Thunder(), new Moves.Thunderbolt(), new Moves.Trick(), new Moves.Trickroom(), new Moves.Wonderroom(), new Moves.Workup(), new Moves.Zenheadbutt() };
	public override List<Move> EggMoves => new List<Move>() { new Moves.Dreameater(), new Moves.Extrasensory(), new Moves.Lastresort(), new Moves.Yawn() };
	public override int Weight => 760;
	public override int ExpYield => 172;
	public override int CatchRate => 45;
	public override Dictionary<Stat, int> EvYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 0,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 2,
		[Stat.Speed] = 0
	};
}