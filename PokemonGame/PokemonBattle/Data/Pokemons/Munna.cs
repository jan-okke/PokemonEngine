using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Munna : Pokemon
{
	public override string Name => "Munna";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Forewarn(), new Abilities.Synchronize() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Telepathy() };
	public override Stats BaseStats => new Stats(76, 25, 45, 67, 55, 24);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Fast;
	public override List<PokemonType> Types => new() {PokemonType.Psychic };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Storedpower(), new Moves.Defensecurl() },
		[4] = new List<Move>() { new Moves.Hypnosis() },
		[8] = new List<Move>() { new Moves.Psybeam() },
		[12] = new List<Move>() { new Moves.Imprison() },
		[16] = new List<Move>() { new Moves.Moonlight() },
		[20] = new List<Move>() { new Moves.Magiccoat() },
		[24] = new List<Move>() { new Moves.Zenheadbutt() },
		[28] = new List<Move>() { new Moves.Calmmind() },
		[32] = new List<Move>() { new Moves.Yawn() },
		[36] = new List<Move>() { new Moves.Psychic() },
		[40] = new List<Move>() { new Moves.Moonblast() },
		[44] = new List<Move>() { new Moves.Dreameater() },
		[48] = new List<Move>() { new Moves.Futuresight() },
		[52] = new List<Move>() { new Moves.Wonderroom() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Allyswitch(), new Moves.Amnesia(), new Moves.Attract(), new Moves.Calmmind(), new Moves.Dazzlinggleam(), new Moves.Endure(), new Moves.Energyball(), new Moves.Expandingforce(), new Moves.Facade(), new Moves.Futuresight(), new Moves.Guardswap(), new Moves.Gyroball(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Imprison(), new Moves.Lightscreen(), new Moves.Powerswap(), new Moves.Protect(), new Moves.Psychic(), new Moves.Psyshock(), new Moves.Raindance(), new Moves.Reflect(), new Moves.Rest(), new Moves.Rockslide(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Safeguard(), new Moves.Shadowball(), new Moves.Skillswap(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Storedpower(), new Moves.Substitute(), new Moves.Swift(), new Moves.Thunderwave(), new Moves.Trick(), new Moves.Trickroom(), new Moves.Wonderroom(), new Moves.Zenheadbutt() };
	public override List<Move> EggMoves => new List<Move>() { new Moves.Curse(), new Moves.Healingwish() };
	public override int Weight => 233;
	public override int ExpYield => 58;
	public override int CatchRate => 190;
	public override Dictionary<Stat, int> EVYield => new()
	{
		[Stat.HP] = 1,
		[Stat.Attack] = 0,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 0,
		[Stat.Speed] = 0
	};
}