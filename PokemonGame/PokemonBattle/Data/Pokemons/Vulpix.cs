using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Vulpix : Pokemon
{
	public override string Name => "Vulpix";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Flashfire() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Drought() };
	public override Stats BaseStats => new Stats(38, 41, 40, 50, 65, 65);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
	public override List<PokemonType> Types => new() {PokemonType.Fire };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Ember(), new Moves.Tailwhip() },
		[4] = new List<Move>() { new Moves.Disable() },
		[8] = new List<Move>() { new Moves.Quickattack() },
		[12] = new List<Move>() { new Moves.Spite() },
		[16] = new List<Move>() { new Moves.Incinerate() },
		[20] = new List<Move>() { new Moves.Confuseray() },
		[24] = new List<Move>() { new Moves.Willowisp() },
		[28] = new List<Move>() { new Moves.Extrasensory() },
		[32] = new List<Move>() { new Moves.Flamethrower() },
		[36] = new List<Move>() { new Moves.Imprison() },
		[40] = new List<Move>() { new Moves.Firespin() },
		[44] = new List<Move>() { new Moves.Safeguard() },
		[48] = new List<Move>() { new Moves.Inferno() },
		[52] = new List<Move>() { new Moves.Grudge() },
		[56] = new List<Move>() { new Moves.Fireblast() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Agility(), new Moves.Attract(), new Moves.Bodyslam(), new Moves.Burningjealousy(), new Moves.Darkpulse(), new Moves.Dig(), new Moves.Doubleteam(), new Moves.Encore(), new Moves.Endure(), new Moves.Energyball(), new Moves.Facade(), new Moves.Fireblast(), new Moves.Firespin(), new Moves.Flamethrower(), new Moves.Flareblitz(), new Moves.Foulplay(), new Moves.Heatwave(), new Moves.Hex(), new Moves.Hiddenpower(), new Moves.Imprison(), new Moves.Irontail(), new Moves.Mysticalfire(), new Moves.Overheat(), new Moves.Payback(), new Moves.Powerswap(), new Moves.Protect(), new Moves.Psychup(), new Moves.Rest(), new Moves.Roar(), new Moves.Round(), new Moves.Safeguard(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Swift(), new Moves.Tailslap(), new Moves.Weatherball(), new Moves.Willowisp(), new Moves.Zenheadbutt() };
	public override List<Move> EggMoves => new List<Move>() { new Moves.Babydolleyes(), new Moves.Disable(), new Moves.Extrasensory(), new Moves.Flail(), new Moves.Flamecharge(), new Moves.Flareblitz(), new Moves.Heatwave(), new Moves.Hex(), new Moves.Howl(), new Moves.Hypnosis(), new Moves.Memento(), new Moves.Powerswap(), new Moves.Spite() };
	public override int Weight => 99;
	public override int ExpYield => 60;
	public override int CatchRate => 190;
	public override Dictionary<Stat, int> EvYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 0,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 1
	};
}