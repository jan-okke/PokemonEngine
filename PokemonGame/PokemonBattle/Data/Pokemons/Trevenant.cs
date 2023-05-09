using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Trevenant : Pokemon
{
	public override string Name => "Trevenant";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Naturalcure(), new Abilities.Frisk() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Harvest() };
	public override Stats BaseStats => new Stats(85, 110, 76, 65, 82, 56);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
	public override List<PokemonType> Types => new() {PokemonType.Ghost, PokemonType.Grass };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[0] = new List<Move>() { new Moves.Shadowclaw() },
		[1] = new List<Move>() { new Moves.Shadowclaw(), new Moves.Astonish(), new Moves.Tackle(), new Moves.Branchpoke(), new Moves.Leechseed() },
		[12] = new List<Move>() { new Moves.Confuseray() },
		[16] = new List<Move>() { new Moves.Willowisp() },
		[20] = new List<Move>() { new Moves.Hex() },
		[24] = new List<Move>() { new Moves.Growth() },
		[28] = new List<Move>() { new Moves.Hornleech() },
		[32] = new List<Move>() { new Moves.Curse() },
		[36] = new List<Move>() { new Moves.Phantomforce() },
		[40] = new List<Move>() { new Moves.Ingrain() },
		[44] = new List<Move>() { new Moves.Woodhammer() },
		[48] = new List<Move>() { new Moves.Destinybond() },
		[52] = new List<Move>() { new Moves.Forestscurse() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Allyswitch(), new Moves.Attract(), new Moves.Brutalswing(), new Moves.Bulldoze(), new Moves.Calmmind(), new Moves.Darkpulse(), new Moves.Dig(), new Moves.Drainpunch(), new Moves.Earthquake(), new Moves.Endure(), new Moves.Energyball(), new Moves.Facade(), new Moves.Focusblast(), new Moves.Foulplay(), new Moves.Gigadrain(), new Moves.Gigaimpact(), new Moves.Grassknot(), new Moves.Grassyglide(), new Moves.Hex(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Imprison(), new Moves.Leafstorm(), new Moves.Magicalleaf(), new Moves.Phantomforce(), new Moves.Poisonjab(), new Moves.Poltergeist(), new Moves.Protect(), new Moves.Psychic(), new Moves.Reflect(), new Moves.Rest(), new Moves.Rockslide(), new Moves.Round(), new Moves.Safeguard(), new Moves.Seedbomb(), new Moves.Shadowball(), new Moves.Shadowclaw(), new Moves.Skillswap(), new Moves.Skittersmack(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Thief(), new Moves.Trick(), new Moves.Trickroom(), new Moves.Venomdrench(), new Moves.Willowisp(), new Moves.Xscissor() };
	public override int Weight => 710;
	public override int ExpYield => 166;
	public override int CatchRate => 60;
	public override Dictionary<Stat, int> EVYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 2,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}